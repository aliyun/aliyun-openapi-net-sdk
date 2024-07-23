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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class ListCustomEntitiesResponseUnmarshaller
    {
        public static ListCustomEntitiesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCustomEntitiesResponse listCustomEntitiesResponse = new ListCustomEntitiesResponse();

			listCustomEntitiesResponse.HttpResponse = _ctx.HttpResponse;
			listCustomEntitiesResponse.RequestId = _ctx.StringValue("ListCustomEntities.RequestId");
			listCustomEntitiesResponse.PageNumber = _ctx.IntegerValue("ListCustomEntities.PageNumber");
			listCustomEntitiesResponse.PageSize = _ctx.IntegerValue("ListCustomEntities.PageSize");
			listCustomEntitiesResponse.TotalCount = _ctx.LongValue("ListCustomEntities.TotalCount");

			List<ListCustomEntitiesResponse.ListCustomEntities_CustomEntity> listCustomEntitiesResponse_customEntities = new List<ListCustomEntitiesResponse.ListCustomEntities_CustomEntity>();
			for (int i = 0; i < _ctx.Length("ListCustomEntities.CustomEntities.Length"); i++) {
				ListCustomEntitiesResponse.ListCustomEntities_CustomEntity customEntity = new ListCustomEntitiesResponse.ListCustomEntities_CustomEntity();
				customEntity.CustomEntityId = _ctx.StringValue("ListCustomEntities.CustomEntities["+ i +"].CustomEntityId");
				customEntity.CustomEntityName = _ctx.StringValue("ListCustomEntities.CustomEntities["+ i +"].CustomEntityName");
				customEntity.CustomEntityInfo = _ctx.StringValue("ListCustomEntities.CustomEntities["+ i +"].CustomEntityInfo");

				listCustomEntitiesResponse_customEntities.Add(customEntity);
			}
			listCustomEntitiesResponse.CustomEntities = listCustomEntitiesResponse_customEntities;
        
			return listCustomEntitiesResponse;
        }
    }
}
