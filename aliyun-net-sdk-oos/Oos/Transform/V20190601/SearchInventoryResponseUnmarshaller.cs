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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class SearchInventoryResponseUnmarshaller
    {
        public static SearchInventoryResponse Unmarshall(UnmarshallerContext context)
        {
			SearchInventoryResponse searchInventoryResponse = new SearchInventoryResponse();

			searchInventoryResponse.HttpResponse = context.HttpResponse;
			searchInventoryResponse.RequestId = context.StringValue("SearchInventory.RequestId");
			searchInventoryResponse.MaxResults = context.IntegerValue("SearchInventory.MaxResults");
			searchInventoryResponse.NextToken = context.StringValue("SearchInventory.NextToken");

			List<Dictionary<string, string>> searchInventoryResponse_entities = new List<Dictionary<string, string>>();
			for (int i = 0; i < context.Length("SearchInventory.Entities.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in context.ResponseDictionary){
					string prefix = "SearchInventory.Entities["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					searchInventoryResponse_entities.Add(tmp);
				}
			}
			searchInventoryResponse.Entities = searchInventoryResponse_entities;
        
			return searchInventoryResponse;
        }
    }
}
