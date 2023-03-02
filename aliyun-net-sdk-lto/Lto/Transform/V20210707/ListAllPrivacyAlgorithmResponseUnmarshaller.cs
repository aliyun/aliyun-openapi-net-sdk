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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class ListAllPrivacyAlgorithmResponseUnmarshaller
    {
        public static ListAllPrivacyAlgorithmResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAllPrivacyAlgorithmResponse listAllPrivacyAlgorithmResponse = new ListAllPrivacyAlgorithmResponse();

			listAllPrivacyAlgorithmResponse.HttpResponse = _ctx.HttpResponse;
			listAllPrivacyAlgorithmResponse.Code = _ctx.StringValue("ListAllPrivacyAlgorithm.Code");
			listAllPrivacyAlgorithmResponse.HttpStatusCode = _ctx.IntegerValue("ListAllPrivacyAlgorithm.HttpStatusCode");
			listAllPrivacyAlgorithmResponse.Message = _ctx.StringValue("ListAllPrivacyAlgorithm.Message");
			listAllPrivacyAlgorithmResponse.RequestId = _ctx.StringValue("ListAllPrivacyAlgorithm.RequestId");
			listAllPrivacyAlgorithmResponse.Success = _ctx.BooleanValue("ListAllPrivacyAlgorithm.Success");

			List<ListAllPrivacyAlgorithmResponse.ListAllPrivacyAlgorithm_AlgTypeInfo> listAllPrivacyAlgorithmResponse_data = new List<ListAllPrivacyAlgorithmResponse.ListAllPrivacyAlgorithm_AlgTypeInfo>();
			for (int i = 0; i < _ctx.Length("ListAllPrivacyAlgorithm.Data.Length"); i++) {
				ListAllPrivacyAlgorithmResponse.ListAllPrivacyAlgorithm_AlgTypeInfo algTypeInfo = new ListAllPrivacyAlgorithmResponse.ListAllPrivacyAlgorithm_AlgTypeInfo();
				algTypeInfo.AlgType = _ctx.StringValue("ListAllPrivacyAlgorithm.Data["+ i +"].AlgType");

				List<string> algTypeInfo_algImplList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListAllPrivacyAlgorithm.Data["+ i +"].AlgImplList.Length"); j++) {
					algTypeInfo_algImplList.Add(_ctx.StringValue("ListAllPrivacyAlgorithm.Data["+ i +"].AlgImplList["+ j +"]"));
				}
				algTypeInfo.AlgImplList = algTypeInfo_algImplList;

				listAllPrivacyAlgorithmResponse_data.Add(algTypeInfo);
			}
			listAllPrivacyAlgorithmResponse.Data = listAllPrivacyAlgorithmResponse_data;
        
			return listAllPrivacyAlgorithmResponse;
        }
    }
}
