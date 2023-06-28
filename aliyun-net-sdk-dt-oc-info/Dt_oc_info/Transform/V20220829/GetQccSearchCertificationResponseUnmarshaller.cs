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
using Aliyun.Acs.dt_oc_info.Model.V20220829;

namespace Aliyun.Acs.dt_oc_info.Transform.V20220829
{
    public class GetQccSearchCertificationResponseUnmarshaller
    {
        public static GetQccSearchCertificationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetQccSearchCertificationResponse getQccSearchCertificationResponse = new GetQccSearchCertificationResponse();

			getQccSearchCertificationResponse.HttpResponse = _ctx.HttpResponse;
			getQccSearchCertificationResponse.Code = _ctx.StringValue("GetQccSearchCertification.Code");
			getQccSearchCertificationResponse.Success = _ctx.BooleanValue("GetQccSearchCertification.Success");
			getQccSearchCertificationResponse.Message = _ctx.StringValue("GetQccSearchCertification.Message");
			getQccSearchCertificationResponse.TotalNum = _ctx.IntegerValue("GetQccSearchCertification.TotalNum");
			getQccSearchCertificationResponse.PageIndex = _ctx.IntegerValue("GetQccSearchCertification.PageIndex");
			getQccSearchCertificationResponse.PageNum = _ctx.IntegerValue("GetQccSearchCertification.PageNum");
			getQccSearchCertificationResponse.RequestId = _ctx.StringValue("GetQccSearchCertification.RequestId");

			List<Dictionary<string, string>> getQccSearchCertificationResponse_data = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("GetQccSearchCertification.Data.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "GetQccSearchCertification.Data["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					getQccSearchCertificationResponse_data.Add(tmp);
				}
			}
			getQccSearchCertificationResponse.Data = getQccSearchCertificationResponse_data;
        
			return getQccSearchCertificationResponse;
        }
    }
}
