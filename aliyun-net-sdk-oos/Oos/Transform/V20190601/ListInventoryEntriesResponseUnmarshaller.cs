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
    public class ListInventoryEntriesResponseUnmarshaller
    {
        public static ListInventoryEntriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInventoryEntriesResponse listInventoryEntriesResponse = new ListInventoryEntriesResponse();

			listInventoryEntriesResponse.HttpResponse = _ctx.HttpResponse;
			listInventoryEntriesResponse.RequestId = _ctx.StringValue("ListInventoryEntries.RequestId");
			listInventoryEntriesResponse.NextToken = _ctx.StringValue("ListInventoryEntries.NextToken");
			listInventoryEntriesResponse.InstanceId = _ctx.StringValue("ListInventoryEntries.InstanceId");
			listInventoryEntriesResponse.CaptureTime = _ctx.StringValue("ListInventoryEntries.CaptureTime");
			listInventoryEntriesResponse.TypeName = _ctx.StringValue("ListInventoryEntries.TypeName");
			listInventoryEntriesResponse.SchemaVersion = _ctx.StringValue("ListInventoryEntries.SchemaVersion");
			listInventoryEntriesResponse.MaxResults = _ctx.IntegerValue("ListInventoryEntries.MaxResults");

			List<Dictionary<string, string>> listInventoryEntriesResponse_entries = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("ListInventoryEntries.Entries.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "ListInventoryEntries.Entries["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					listInventoryEntriesResponse_entries.Add(tmp);
				}
			}
			listInventoryEntriesResponse.Entries = listInventoryEntriesResponse_entries;
        
			return listInventoryEntriesResponse;
        }
    }
}
