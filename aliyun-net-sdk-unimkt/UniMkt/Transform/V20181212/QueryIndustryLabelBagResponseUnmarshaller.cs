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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class QueryIndustryLabelBagResponseUnmarshaller
    {
        public static QueryIndustryLabelBagResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryIndustryLabelBagResponse queryIndustryLabelBagResponse = new QueryIndustryLabelBagResponse();

			queryIndustryLabelBagResponse.HttpResponse = _ctx.HttpResponse;
			queryIndustryLabelBagResponse.Code = _ctx.IntegerValue("QueryIndustryLabelBag.Code");
			queryIndustryLabelBagResponse.Success = _ctx.BooleanValue("QueryIndustryLabelBag.Success");
			queryIndustryLabelBagResponse.ErrorMsg = _ctx.StringValue("QueryIndustryLabelBag.ErrorMsg");
			queryIndustryLabelBagResponse.RequestId = _ctx.StringValue("QueryIndustryLabelBag.RequestId");

			List<Dictionary<string, string>> queryIndustryLabelBagResponse_data = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("QueryIndustryLabelBag.Data.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "QueryIndustryLabelBag.Data["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					queryIndustryLabelBagResponse_data.Add(tmp);
				}
			}
			queryIndustryLabelBagResponse.Data = queryIndustryLabelBagResponse_data;
        
			return queryIndustryLabelBagResponse;
        }
    }
}
