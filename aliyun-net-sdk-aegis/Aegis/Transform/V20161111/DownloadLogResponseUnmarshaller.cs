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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DownloadLogResponseUnmarshaller
    {
        public static DownloadLogResponse Unmarshall(UnmarshallerContext context)
        {
			DownloadLogResponse downloadLogResponse = new DownloadLogResponse();

			downloadLogResponse.HttpResponse = context.HttpResponse;
			downloadLogResponse.RequestId = context.StringValue("DownloadLog.RequestId");

			List<string> downloadLogResponse_suppressed = new List<string>();
			for (int i = 0; i < context.Length("DownloadLog.Suppressed.Length"); i++) {
				downloadLogResponse_suppressed.Add(context.StringValue("DownloadLog.Suppressed["+ i +"]"));
			}
			downloadLogResponse.Suppressed = downloadLogResponse_suppressed;

			List<DownloadLogResponse.DownloadLog_StackTraceItem> downloadLogResponse_stackTrace = new List<DownloadLogResponse.DownloadLog_StackTraceItem>();
			for (int i = 0; i < context.Length("DownloadLog.StackTrace.Length"); i++) {
				DownloadLogResponse.DownloadLog_StackTraceItem stackTraceItem = new DownloadLogResponse.DownloadLog_StackTraceItem();
				stackTraceItem.FileName = context.StringValue("DownloadLog.StackTrace["+ i +"].FileName");
				stackTraceItem.NativeMethod = context.BooleanValue("DownloadLog.StackTrace["+ i +"].NativeMethod");
				stackTraceItem.MethodName = context.StringValue("DownloadLog.StackTrace["+ i +"].MethodName");
				stackTraceItem.ClassName = context.StringValue("DownloadLog.StackTrace["+ i +"].ClassName");
				stackTraceItem.LineNumber = context.IntegerValue("DownloadLog.StackTrace["+ i +"].LineNumber");

				downloadLogResponse_stackTrace.Add(stackTraceItem);
			}
			downloadLogResponse.StackTrace = downloadLogResponse_stackTrace;
        
			return downloadLogResponse;
        }
    }
}
