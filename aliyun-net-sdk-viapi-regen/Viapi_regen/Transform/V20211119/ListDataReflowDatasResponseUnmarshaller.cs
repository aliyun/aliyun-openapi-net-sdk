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
using Aliyun.Acs.viapi_regen.Model.V20211119;

namespace Aliyun.Acs.viapi_regen.Transform.V20211119
{
    public class ListDataReflowDatasResponseUnmarshaller
    {
        public static ListDataReflowDatasResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataReflowDatasResponse listDataReflowDatasResponse = new ListDataReflowDatasResponse();

			listDataReflowDatasResponse.HttpResponse = _ctx.HttpResponse;
			listDataReflowDatasResponse.Message = _ctx.StringValue("ListDataReflowDatas.Message");
			listDataReflowDatasResponse.RequestId = _ctx.StringValue("ListDataReflowDatas.RequestId");
			listDataReflowDatasResponse.Code = _ctx.StringValue("ListDataReflowDatas.Code");

			ListDataReflowDatasResponse.ListDataReflowDatas_Data data = new ListDataReflowDatasResponse.ListDataReflowDatas_Data();
			data.CurrentPage = _ctx.LongValue("ListDataReflowDatas.Data.CurrentPage");
			data.PageSize = _ctx.LongValue("ListDataReflowDatas.Data.PageSize");
			data.TotalPage = _ctx.LongValue("ListDataReflowDatas.Data.TotalPage");
			data.TotalCount = _ctx.LongValue("ListDataReflowDatas.Data.TotalCount");

			List<Dictionary<string, string>> data_elements = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("ListDataReflowDatas.Data.Elements.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "ListDataReflowDatas.Data.Elements["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					data_elements.Add(tmp);
				}
			}
			data.Elements = data_elements;
			listDataReflowDatasResponse.Data = data;
        
			return listDataReflowDatasResponse;
        }
    }
}
