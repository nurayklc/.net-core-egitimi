﻿FileLogger fileLogger = new FileLogger();
fileLogger.WriteLog();

DatabaseLogger databaseLogger = new DatabaseLogger();
databaseLogger.WriteLog();

SmsLogger smsLogger = new();
smsLogger.WriteLog();

LogManager logManager = new LogManager(new FileLogger());
logManager.WriteLog();