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
    public class DescribeSuspEventQuaraFilesResponseUnmarshaller
    {
        public static DescribeSuspEventQuaraFilesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSuspEventQuaraFilesResponse describeSuspEventQuaraFilesResponse = new DescribeSuspEventQuaraFilesResponse();

			describeSuspEventQuaraFilesResponse.HttpResponse = context.HttpResponse;
			describeSuspEventQuaraFilesResponse.RequestId = context.StringValue("DescribeSuspEventQuaraFiles.RequestId");
			describeSuspEventQuaraFilesResponse.Count = context.IntegerValue("DescribeSuspEventQuaraFiles.Count");
			describeSuspEventQuaraFilesResponse.PageSize = context.IntegerValue("DescribeSuspEventQuaraFiles.PageSize");
			describeSuspEventQuaraFilesResponse.TotalCount = context.IntegerValue("DescribeSuspEventQuaraFiles.TotalCount");
			describeSuspEventQuaraFilesResponse.CurrentPage = context.IntegerValue("DescribeSuspEventQuaraFiles.CurrentPage");

			List<DescribeSuspEventQuaraFilesResponse.DescribeSuspEventQuaraFiles_QuaraFile> describeSuspEventQuaraFilesResponse_quaraFiles = new List<DescribeSuspEventQuaraFilesResponse.DescribeSuspEventQuaraFiles_QuaraFile>();
			for (int i = 0; i < context.Length("DescribeSuspEventQuaraFiles.QuaraFiles.Length"); i++) {
				DescribeSuspEventQuaraFilesResponse.DescribeSuspEventQuaraFiles_QuaraFile quaraFile = new DescribeSuspEventQuaraFilesResponse.DescribeSuspEventQuaraFiles_QuaraFile();
				quaraFile.Path = context.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].Path");
				quaraFile.EventName = context.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].EventName");
				quaraFile.Id = context.IntegerValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].Id");
				quaraFile.EventType = context.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].EventType");
				quaraFile.Tag = context.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].Tag");
				quaraFile.Uuid = context.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].Uuid");
				quaraFile.InstanceName = context.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].InstanceName");
				quaraFile.InternetIp = context.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].InternetIp");
				quaraFile.Ip = context.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].Ip");
				quaraFile.Status = context.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].Status");
				quaraFile.Md5 = context.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].Md5");
				quaraFile.ModifyTime = context.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].ModifyTime");

				describeSuspEventQuaraFilesResponse_quaraFiles.Add(quaraFile);
			}
			describeSuspEventQuaraFilesResponse.QuaraFiles = describeSuspEventQuaraFilesResponse_quaraFiles;
        
			return describeSuspEventQuaraFilesResponse;
        }
    }
}
