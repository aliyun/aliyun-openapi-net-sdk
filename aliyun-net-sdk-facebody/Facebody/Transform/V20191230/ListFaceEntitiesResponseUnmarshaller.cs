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
using Aliyun.Acs.facebody.Model.V20191230;

namespace Aliyun.Acs.facebody.Transform.V20191230
{
    public class ListFaceEntitiesResponseUnmarshaller
    {
        public static ListFaceEntitiesResponse Unmarshall(UnmarshallerContext context)
        {
			ListFaceEntitiesResponse listFaceEntitiesResponse = new ListFaceEntitiesResponse();

			listFaceEntitiesResponse.HttpResponse = context.HttpResponse;
			listFaceEntitiesResponse.RequestId = context.StringValue("ListFaceEntities.RequestId");

			ListFaceEntitiesResponse.ListFaceEntities_Data data = new ListFaceEntitiesResponse.ListFaceEntities_Data();
			data.Token = context.StringValue("ListFaceEntities.Data.Token");
			data.TotalCount = context.IntegerValue("ListFaceEntities.Data.TotalCount");

			List<ListFaceEntitiesResponse.ListFaceEntities_Data.ListFaceEntities_Entity> data_entities = new List<ListFaceEntitiesResponse.ListFaceEntities_Data.ListFaceEntities_Entity>();
			for (int i = 0; i < context.Length("ListFaceEntities.Data.Entities.Length"); i++) {
				ListFaceEntitiesResponse.ListFaceEntities_Data.ListFaceEntities_Entity entity = new ListFaceEntitiesResponse.ListFaceEntities_Data.ListFaceEntities_Entity();
				entity.DbName = context.StringValue("ListFaceEntities.Data.Entities["+ i +"].DbName");
				entity.EntityId = context.StringValue("ListFaceEntities.Data.Entities["+ i +"].EntityId");
				entity.FaceCount = context.IntegerValue("ListFaceEntities.Data.Entities["+ i +"].FaceCount");
				entity.Labels = context.StringValue("ListFaceEntities.Data.Entities["+ i +"].Labels");
				entity.CreatedAt = context.LongValue("ListFaceEntities.Data.Entities["+ i +"].CreatedAt");
				entity.UpdatedAt = context.LongValue("ListFaceEntities.Data.Entities["+ i +"].UpdatedAt");

				data_entities.Add(entity);
			}
			data.Entities = data_entities;
			listFaceEntitiesResponse.Data = data;
        
			return listFaceEntitiesResponse;
        }
    }
}
