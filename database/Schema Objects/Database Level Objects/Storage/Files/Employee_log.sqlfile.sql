ALTER DATABASE [$(DatabaseName)]
    ADD LOG FILE (NAME = [Employee_log], FILENAME = '$(DefaultLogPath)$(DatabaseName)_log.ldf', SIZE = 1024 KB, MAXSIZE = 2097152 MB, FILEGROWTH = 10 %);

