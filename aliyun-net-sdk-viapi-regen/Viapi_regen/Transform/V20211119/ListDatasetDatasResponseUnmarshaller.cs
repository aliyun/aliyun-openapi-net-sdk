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
    public class ListDatasetDatasResponseUnmarshaller
    {
        public static ListDatasetDatasResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDatasetDatasResponse listDatasetDatasResponse = new ListDatasetDatasResponse();

			listDatasetDatasResponse.HttpResponse = _ctx.HttpResponse;
			listDatasetDatasResponse.Message = _ctx.StringValue("ListDatasetDatas.Message");
			listDatasetDatasResponse.RequestId = _ctx.StringValue("ListDatasetDatas.RequestId");
			listDatasetDatasResponse.Code = _ctx.StringValue("ListDatasetDatas.Code");

			ListDatasetDatasResponse.ListDatasetDatas_Data data = new ListDatasetDatasResponse.ListDatasetDatas_Data();
			data.CurrentPage = _ctx.LongValue("ListDatasetDatas.Data.CurrentPage");
			data.PageSize = _ctx.LongValue("ListDatasetDatas.Data.PageSize");
			data.TotalPage = _ctx.LongValue("ListDatasetDatas.Data.TotalPage");
			data.TotalCount = _ctx.LongValue("ListDatasetDatas.Data.TotalCount");

			List<Dictionary<string, string>> data_elements = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("ListDatasetDatas.Data.Elements.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "ListDatasetDatas.Data.Elements["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					data_elements.Add(tmp);
				}
			}
			data.Elements = data_elements;
			listDatasetDatasResponse.Data = data;
        
			return listDatasetDatasResponse;
        }
    }
}
