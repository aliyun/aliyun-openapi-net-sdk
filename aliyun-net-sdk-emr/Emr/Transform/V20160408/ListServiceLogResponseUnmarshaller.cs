/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListServiceLogResponseUnmarshaller
    {
        public static ListServiceLogResponse Unmarshall(UnmarshallerContext context)
        {
			ListServiceLogResponse listServiceLogResponse = new ListServiceLogResponse();

			listServiceLogResponse.HttpResponse = context.HttpResponse;
			listServiceLogResponse.RequestId = context.StringValue("ListServiceLog.RequestId");

			List<ListServiceLogResponse.ListServiceLog_LogFile> listServiceLogResponse_logFileList = new List<ListServiceLogResponse.ListServiceLog_LogFile>();
			for (int i = 0; i < context.Length("ListServiceLog.LogFileList.Length"); i++) {
				ListServiceLogResponse.ListServiceLog_LogFile logFile = new ListServiceLogResponse.ListServiceLog_LogFile();
				logFile.FileName = context.StringValue("ListServiceLog.LogFileList["+ i +"].FileName");
				logFile.Size = context.LongValue("ListServiceLog.LogFileList["+ i +"].Size");
				logFile.HostName = context.StringValue("ListServiceLog.LogFileList["+ i +"].HostName");
				logFile.LastModified = context.LongValue("ListServiceLog.LogFileList["+ i +"].LastModified");

				listServiceLogResponse_logFileList.Add(logFile);
			}
			listServiceLogResponse.LogFileList = listServiceLogResponse_logFileList;
        
			return listServiceLogResponse;
        }
    }
}
