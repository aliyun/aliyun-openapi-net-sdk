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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeSuspEventQuaraFilesResponseUnmarshaller
    {
        public static DescribeSuspEventQuaraFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSuspEventQuaraFilesResponse describeSuspEventQuaraFilesResponse = new DescribeSuspEventQuaraFilesResponse();

			describeSuspEventQuaraFilesResponse.HttpResponse = _ctx.HttpResponse;
			describeSuspEventQuaraFilesResponse.RequestId = _ctx.StringValue("DescribeSuspEventQuaraFiles.RequestId");
			describeSuspEventQuaraFilesResponse.Count = _ctx.IntegerValue("DescribeSuspEventQuaraFiles.Count");
			describeSuspEventQuaraFilesResponse.PageSize = _ctx.IntegerValue("DescribeSuspEventQuaraFiles.PageSize");
			describeSuspEventQuaraFilesResponse.TotalCount = _ctx.IntegerValue("DescribeSuspEventQuaraFiles.TotalCount");
			describeSuspEventQuaraFilesResponse.CurrentPage = _ctx.IntegerValue("DescribeSuspEventQuaraFiles.CurrentPage");

			List<DescribeSuspEventQuaraFilesResponse.DescribeSuspEventQuaraFiles_QuaraFile> describeSuspEventQuaraFilesResponse_quaraFiles = new List<DescribeSuspEventQuaraFilesResponse.DescribeSuspEventQuaraFiles_QuaraFile>();
			for (int i = 0; i < _ctx.Length("DescribeSuspEventQuaraFiles.QuaraFiles.Length"); i++) {
				DescribeSuspEventQuaraFilesResponse.DescribeSuspEventQuaraFiles_QuaraFile quaraFile = new DescribeSuspEventQuaraFilesResponse.DescribeSuspEventQuaraFiles_QuaraFile();
				quaraFile.Path = _ctx.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].Path");
				quaraFile.EventName = _ctx.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].EventName");
				quaraFile.Id = _ctx.IntegerValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].Id");
				quaraFile.EventType = _ctx.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].EventType");
				quaraFile.Tag = _ctx.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].Tag");
				quaraFile.Uuid = _ctx.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].Uuid");
				quaraFile.InstanceId = _ctx.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].InstanceId");
				quaraFile.InstanceName = _ctx.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].InstanceName");
				quaraFile.InternetIp = _ctx.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].InternetIp");
				quaraFile.Ip = _ctx.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].Ip");
				quaraFile.Status = _ctx.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].Status");
				quaraFile.Md5 = _ctx.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].Md5");
				quaraFile.ModifyTime = _ctx.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].ModifyTime");
				quaraFile.Link = _ctx.StringValue("DescribeSuspEventQuaraFiles.QuaraFiles["+ i +"].Link");

				describeSuspEventQuaraFilesResponse_quaraFiles.Add(quaraFile);
			}
			describeSuspEventQuaraFilesResponse.QuaraFiles = describeSuspEventQuaraFilesResponse_quaraFiles;
        
			return describeSuspEventQuaraFilesResponse;
        }
    }
}
