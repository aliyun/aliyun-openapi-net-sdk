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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListFaceSetsResponseUnmarshaller
    {
        public static ListFaceSetsResponse Unmarshall(UnmarshallerContext context)
        {
			ListFaceSetsResponse listFaceSetsResponse = new ListFaceSetsResponse();

			listFaceSetsResponse.HttpResponse = context.HttpResponse;
			listFaceSetsResponse.RequestId = context.StringValue("ListFaceSets.RequestId");
			listFaceSetsResponse.NextMarker = context.StringValue("ListFaceSets.NextMarker");

			List<ListFaceSetsResponse.ListFaceSets_SetsItem> listFaceSetsResponse_sets = new List<ListFaceSetsResponse.ListFaceSets_SetsItem>();
			for (int i = 0; i < context.Length("ListFaceSets.Sets.Length"); i++) {
				ListFaceSetsResponse.ListFaceSets_SetsItem setsItem = new ListFaceSetsResponse.ListFaceSets_SetsItem();
				setsItem.SetId = context.StringValue("ListFaceSets.Sets["+ i +"].SetId");
				setsItem.Status = context.StringValue("ListFaceSets.Sets["+ i +"].Status");
				setsItem.Photos = context.LongValue("ListFaceSets.Sets["+ i +"].Photos");
				setsItem.CreateTime = context.StringValue("ListFaceSets.Sets["+ i +"].CreateTime");
				setsItem.ModifyTime = context.StringValue("ListFaceSets.Sets["+ i +"].ModifyTime");
				setsItem.Faces = context.LongValue("ListFaceSets.Sets["+ i +"].Faces");

				listFaceSetsResponse_sets.Add(setsItem);
			}
			listFaceSetsResponse.Sets = listFaceSetsResponse_sets;
        
			return listFaceSetsResponse;
        }
    }
}