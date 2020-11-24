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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeOpEntitiesResponseUnmarshaller
    {
        public static DescribeOpEntitiesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOpEntitiesResponse describeOpEntitiesResponse = new DescribeOpEntitiesResponse();

			describeOpEntitiesResponse.HttpResponse = _ctx.HttpResponse;
			describeOpEntitiesResponse.RequestId = _ctx.StringValue("DescribeOpEntities.RequestId");
			describeOpEntitiesResponse.TotalCount = _ctx.LongValue("DescribeOpEntities.TotalCount");

			List<DescribeOpEntitiesResponse.DescribeOpEntities_OpEntity> describeOpEntitiesResponse_opEntities = new List<DescribeOpEntitiesResponse.DescribeOpEntities_OpEntity>();
			for (int i = 0; i < _ctx.Length("DescribeOpEntities.OpEntities.Length"); i++) {
				DescribeOpEntitiesResponse.DescribeOpEntities_OpEntity opEntity = new DescribeOpEntitiesResponse.DescribeOpEntities_OpEntity();
				opEntity.GmtCreate = _ctx.LongValue("DescribeOpEntities.OpEntities["+ i +"].GmtCreate");
				opEntity.EntityType = _ctx.IntegerValue("DescribeOpEntities.OpEntities["+ i +"].EntityType");
				opEntity.EntityObject = _ctx.StringValue("DescribeOpEntities.OpEntities["+ i +"].EntityObject");
				opEntity.OpAction = _ctx.IntegerValue("DescribeOpEntities.OpEntities["+ i +"].OpAction");
				opEntity.OpAccount = _ctx.StringValue("DescribeOpEntities.OpEntities["+ i +"].OpAccount");
				opEntity.OpDesc = _ctx.StringValue("DescribeOpEntities.OpEntities["+ i +"].OpDesc");

				describeOpEntitiesResponse_opEntities.Add(opEntity);
			}
			describeOpEntitiesResponse.OpEntities = describeOpEntitiesResponse_opEntities;
        
			return describeOpEntitiesResponse;
        }
    }
}
