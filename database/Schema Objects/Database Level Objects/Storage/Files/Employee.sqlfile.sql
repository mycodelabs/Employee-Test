ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [Employee], FILENAME = '$(DefaultDataPath)$(DatabaseName).mdf', SIZE = 2304 KB, FILEGROWTH = 1024 KB) TO FILEGROUP [PRIMARY];

