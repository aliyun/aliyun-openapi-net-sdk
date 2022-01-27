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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListSetsResponseUnmarshaller
    {
        public static ListSetsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSetsResponse listSetsResponse = new ListSetsResponse();

			listSetsResponse.HttpResponse = _ctx.HttpResponse;
			listSetsResponse.RequestId = _ctx.StringValue("ListSets.RequestId");
			listSetsResponse.NextMarker = _ctx.StringValue("ListSets.NextMarker");

			List<ListSetsResponse.ListSets_SetsItem> listSetsResponse_sets = new List<ListSetsResponse.ListSets_SetsItem>();
			for (int i = 0; i < _ctx.Length("ListSets.Sets.Length"); i++) {
				ListSetsResponse.ListSets_SetsItem setsItem = new ListSetsResponse.ListSets_SetsItem();
				setsItem.SetId = _ctx.StringValue("ListSets.Sets["+ i +"].SetId");
				setsItem.SetName = _ctx.StringValue("ListSets.Sets["+ i +"].SetName");
				setsItem.CreateTime = _ctx.StringValue("ListSets.Sets["+ i +"].CreateTime");
				setsItem.ModifyTime = _ctx.StringValue("ListSets.Sets["+ i +"].ModifyTime");
				setsItem.FaceCount = _ctx.IntegerValue("ListSets.Sets["+ i +"].FaceCount");
				setsItem.ImageCount = _ctx.IntegerValue("ListSets.Sets["+ i +"].ImageCount");
				setsItem.VideoCount = _ctx.IntegerValue("ListSets.Sets["+ i +"].VideoCount");
				setsItem.VideoLength = _ctx.IntegerValue("ListSets.Sets["+ i +"].VideoLength");

				listSetsResponse_sets.Add(setsItem);
			}
			listSetsResponse.Sets = listSetsResponse_sets;
        
			return listSetsResponse;
        }
    }
}
