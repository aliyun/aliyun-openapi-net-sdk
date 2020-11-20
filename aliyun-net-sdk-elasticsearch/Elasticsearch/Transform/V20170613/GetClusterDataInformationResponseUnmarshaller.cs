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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class GetClusterDataInformationResponseUnmarshaller
    {
        public static GetClusterDataInformationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetClusterDataInformationResponse getClusterDataInformationResponse = new GetClusterDataInformationResponse();

			getClusterDataInformationResponse.HttpResponse = _ctx.HttpResponse;
			getClusterDataInformationResponse.RequestId = _ctx.StringValue("GetClusterDataInformation.RequestId");

			GetClusterDataInformationResponse.GetClusterDataInformation_Result result = new GetClusterDataInformationResponse.GetClusterDataInformation_Result();
			result.Connectable = _ctx.BooleanValue("GetClusterDataInformation.Result.connectable");

			GetClusterDataInformationResponse.GetClusterDataInformation_Result.GetClusterDataInformation_MetaInfo metaInfo = new GetClusterDataInformationResponse.GetClusterDataInformation_Result.GetClusterDataInformation_MetaInfo();
			metaInfo.Settings = _ctx.StringValue("GetClusterDataInformation.Result.MetaInfo.settings");
			metaInfo.Mapping = _ctx.StringValue("GetClusterDataInformation.Result.MetaInfo.mapping");

			List<string> metaInfo_indices = new List<string>();
			for (int i = 0; i < _ctx.Length("GetClusterDataInformation.Result.MetaInfo.Indices.Length"); i++) {
				metaInfo_indices.Add(_ctx.StringValue("GetClusterDataInformation.Result.MetaInfo.Indices["+ i +"]"));
			}
			metaInfo.Indices = metaInfo_indices;

			List<string> metaInfo_fields = new List<string>();
			for (int i = 0; i < _ctx.Length("GetClusterDataInformation.Result.MetaInfo.Fields.Length"); i++) {
				metaInfo_fields.Add(_ctx.StringValue("GetClusterDataInformation.Result.MetaInfo.Fields["+ i +"]"));
			}
			metaInfo.Fields = metaInfo_fields;

			List<string> metaInfo_typeName = new List<string>();
			for (int i = 0; i < _ctx.Length("GetClusterDataInformation.Result.MetaInfo.TypeName.Length"); i++) {
				metaInfo_typeName.Add(_ctx.StringValue("GetClusterDataInformation.Result.MetaInfo.TypeName["+ i +"]"));
			}
			metaInfo.TypeName = metaInfo_typeName;
			result.MetaInfo = metaInfo;
			getClusterDataInformationResponse.Result = result;
        
			return getClusterDataInformationResponse;
        }
    }
}
