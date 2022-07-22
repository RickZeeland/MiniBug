// Copyright(c) João Martiniano. All rights reserved.
// Licensed under the MIT license.

using System.IO;
using Newtonsoft.Json;

namespace MiniBug
{
    public enum OperationType { None = 0, New, Edit, Delete };

    /// <summary>
    /// Identify which grid to reference of performe some operation.
    /// </summary>
    public enum GridType { None = 0, All, Issues, Tasks }

    /// <summary>
    /// Result of a filesystem operation.
    /// </summary>
    public enum FileSystemOperationStatus {
        None = 0,

        /// <summary>The operation was successfull.</summary>
        OK = 1,

        /// <summary>Trying to load a project with an unsupported file format.</summary>
        ProjectLoadErrorUnsupportedFormat,

        /// <summary>Trying to load a project file from a non-existing directory.</summary>
        ProjectLoadErrorDirectoryNotFound,

        /// <summary>File not found while trying to load a project.</summary>
        ProjectLoadErrorFileNotFound,

        /// <summary>Project file path and/or file name too long.</summary>
        ProjectLoadErrorPathTooLong,

        /// <summary>Error deserializing the project file.</summary>
        ProjectLoadErrorDeserialization,

        /// <summary>General I/O error while trying to load the project file.</summary>
        ProjectLoadErrorIO,

        /// <summary>Trying to save a project file to a non-existing directory.</summary>
        ProjectSaveErrorDirectoryNotFound,

        /// <summary>Project file's path and/or file name too long.</summary>
        ProjectSaveErrorPathTooLong,

        /// <summary>Error serializing the project file.</summary>
        ProjectSaveErrorSerialization,

        /// <summary>General I/O error while trying to save the project file.</summary>
        ProjectSaveIOError,

        /// <summary>Project successfully exported.</summary>
        ExportOK,

        /// <summary>Export projet to CSV: trying to export to a non-existing directory.</summary>
        ExportToCsvErrorDirectoryNotFound,

        /// <summary>Export projet to CSV: file path and/or file name too long.</summary>
        ExportToCsvErrorPathTooLong,

        /// <summary>Export projet to CSV: error reported by the component responsible for performing the export.</summary>
        ExportToCsvErrorExporterComponent,

        /// <summary>Export projet to CSV: general I/O error.</summary>
        ExportToCsvIOError
    }

    public static class ApplicationData
    {
        /// <summary>
        /// Saves a project data to a file. The file is overwritten.
        /// </summary>
        /// <param name="softwareProject">An instance of the Project class.</param>
        public static FileSystemOperationStatus SaveProject(in Project softwareProject)
        {
            //string output = JsonConvert.SerializeObject(softwareProject, Formatting.Indented);        // Save with indentation
            string output = JsonConvert.SerializeObject(softwareProject);
            string filename = Path.Combine(softwareProject.Location, softwareProject.Filename);

            try
            {
                File.WriteAllText(filename, output);
            }
            catch (System.IO.DirectoryNotFoundException) // The directory does not exist
            {
                return FileSystemOperationStatus.ProjectSaveErrorDirectoryNotFound;
            }
            catch (System.IO.PathTooLongException) // The path is too long
            {
                return FileSystemOperationStatus.ProjectSaveErrorPathTooLong;
            }
            catch (JsonException) // Error serializing the project
            {
                return FileSystemOperationStatus.ProjectSaveErrorSerialization;
            }
            catch // General input/output error
            {
                return FileSystemOperationStatus.ProjectSaveIOError;
            }

            return FileSystemOperationStatus.OK;
        }

        /// <summary>
        /// Load project data from a file.
        /// </summary>
        /// <param name="fullFilename">Name and location of the project file.</param>
        /// <param name="softwareProject">An instance of the Project class.</param>
        public static FileSystemOperationStatus LoadProject(string fullFilename, out Project softwareProject)
        {
            try
            {
                string input = File.ReadAllText(fullFilename);
                softwareProject = JsonConvert.DeserializeObject<Project>(input);

                // Check the version of the project file: if not supported, abort the operation
                if (softwareProject.Version != ApplicationSettings.ProjectFileFormatVersion)
                {
                    softwareProject = null;
                    return FileSystemOperationStatus.ProjectLoadErrorUnsupportedFormat;
                }

                // Insert the path and filename into the project
                softwareProject.Location = Path.GetDirectoryName(fullFilename);
                softwareProject.Filename = Path.GetFileName(fullFilename);
            }
            catch (System.IO.DirectoryNotFoundException) // The directory does not exist
            {
                softwareProject = null;
                return FileSystemOperationStatus.ProjectLoadErrorDirectoryNotFound;
            }
            catch (System.IO.FileNotFoundException) // The file does not exist
            {
                softwareProject = null;
                return FileSystemOperationStatus.ProjectLoadErrorFileNotFound;
            }
            catch (System.IO.PathTooLongException) // The path is too long
            {
                softwareProject = null;
                return FileSystemOperationStatus.ProjectLoadErrorPathTooLong;
            }
            catch (JsonException) // Error deserializing the file
            {
                softwareProject = null;
                return FileSystemOperationStatus.ProjectLoadErrorDeserialization;
            }
            catch // General input/output error
            {
                softwareProject = null;
                return FileSystemOperationStatus.ProjectLoadErrorIO;
            }

            return FileSystemOperationStatus.OK;
        }
    }
}
