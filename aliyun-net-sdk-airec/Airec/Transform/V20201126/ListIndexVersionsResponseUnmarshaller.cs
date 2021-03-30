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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class ListIndexVersionsResponseUnmarshaller
    {
        public static ListIndexVersionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListIndexVersionsResponse listIndexVersionsResponse = new ListIndexVersionsResponse();

			listIndexVersionsResponse.HttpResponse = _ctx.HttpResponse;
			listIndexVersionsResponse.RequestId = _ctx.StringValue("ListIndexVersions.requestId");

			List<ListIndexVersionsResponse.ListIndexVersions_IndeVersion> listIndexVersionsResponse_result = new List<ListIndexVersionsResponse.ListIndexVersions_IndeVersion>();
			for (int i = 0; i < _ctx.Length("ListIndexVersions.Result.Length"); i++) {
				ListIndexVersionsResponse.ListIndexVersions_IndeVersion indeVersion = new ListIndexVersionsResponse.ListIndexVersions_IndeVersion();
				indeVersion.VersionId = _ctx.StringValue("ListIndexVersions.Result["+ i +"].versionId");
				indeVersion.Status = _ctx.StringValue("ListIndexVersions.Result["+ i +"].status");
				indeVersion.BuiltTime = _ctx.StringValue("ListIndexVersions.Result["+ i +"].builtTime");
				indeVersion.SwitchedTime = _ctx.StringValue("ListIndexVersions.Result["+ i +"].switchedTime");
				indeVersion.RollbackEnabled = _ctx.BooleanValue("ListIndexVersions.Result["+ i +"].rollbackEnabled");
				indeVersion.CostSeconds = _ctx.IntegerValue("ListIndexVersions.Result["+ i +"].costSeconds");
				indeVersion.Size = _ctx.LongValue("ListIndexVersions.Result["+ i +"].size");
				indeVersion.Progress = _ctx.IntegerValue("ListIndexVersions.Result["+ i +"].progress");
				indeVersion.FlowType = _ctx.StringValue("ListIndexVersions.Result["+ i +"].flowType");
				indeVersion.Code = _ctx.StringValue("ListIndexVersions.Result["+ i +"].code");
				indeVersion.Message = _ctx.StringValue("ListIndexVersions.Result["+ i +"].message");

				listIndexVersionsResponse_result.Add(indeVersion);
			}
			listIndexVersionsResponse.Result = listIndexVersionsResponse_result;
        
			return listIndexVersionsResponse;
        }
    }
}
