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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListHistoryDeployVersionResponseUnmarshaller
    {
        public static ListHistoryDeployVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListHistoryDeployVersionResponse listHistoryDeployVersionResponse = new ListHistoryDeployVersionResponse();

			listHistoryDeployVersionResponse.HttpResponse = _ctx.HttpResponse;
			listHistoryDeployVersionResponse.Code = _ctx.IntegerValue("ListHistoryDeployVersion.Code");
			listHistoryDeployVersionResponse.Message = _ctx.StringValue("ListHistoryDeployVersion.Message");
			listHistoryDeployVersionResponse.RequestId = _ctx.StringValue("ListHistoryDeployVersion.RequestId");

			List<ListHistoryDeployVersionResponse.ListHistoryDeployVersion_PackageVersion> listHistoryDeployVersionResponse_packageVersionList = new List<ListHistoryDeployVersionResponse.ListHistoryDeployVersion_PackageVersion>();
			for (int i = 0; i < _ctx.Length("ListHistoryDeployVersion.PackageVersionList.Length"); i++) {
				ListHistoryDeployVersionResponse.ListHistoryDeployVersion_PackageVersion packageVersion = new ListHistoryDeployVersionResponse.ListHistoryDeployVersion_PackageVersion();
				packageVersion.Id = _ctx.StringValue("ListHistoryDeployVersion.PackageVersionList["+ i +"].Id");
				packageVersion.PackageVersion = _ctx.StringValue("ListHistoryDeployVersion.PackageVersionList["+ i +"].PackageVersion");
				packageVersion.AppId = _ctx.StringValue("ListHistoryDeployVersion.PackageVersionList["+ i +"].AppId");
				packageVersion.Description = _ctx.StringValue("ListHistoryDeployVersion.PackageVersionList["+ i +"].Description");
				packageVersion.WarUrl = _ctx.StringValue("ListHistoryDeployVersion.PackageVersionList["+ i +"].WarUrl");
				packageVersion.CreateTime = _ctx.LongValue("ListHistoryDeployVersion.PackageVersionList["+ i +"].CreateTime");
				packageVersion.UpdateTime = _ctx.LongValue("ListHistoryDeployVersion.PackageVersionList["+ i +"].UpdateTime");
				packageVersion.Type = _ctx.StringValue("ListHistoryDeployVersion.PackageVersionList["+ i +"].Type");
				packageVersion.PublicUrl = _ctx.StringValue("ListHistoryDeployVersion.PackageVersionList["+ i +"].PublicUrl");

				listHistoryDeployVersionResponse_packageVersionList.Add(packageVersion);
			}
			listHistoryDeployVersionResponse.PackageVersionList = listHistoryDeployVersionResponse_packageVersionList;
        
			return listHistoryDeployVersionResponse;
        }
    }
}
