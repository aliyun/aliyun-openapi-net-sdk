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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeAllEntityResponseUnmarshaller
    {
        public static DescribeAllEntityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAllEntityResponse describeAllEntityResponse = new DescribeAllEntityResponse();

			describeAllEntityResponse.HttpResponse = _ctx.HttpResponse;
			describeAllEntityResponse.RequestId = _ctx.StringValue("DescribeAllEntity.RequestId");

			List<DescribeAllEntityResponse.DescribeAllEntity_Entity> describeAllEntityResponse_entityList = new List<DescribeAllEntityResponse.DescribeAllEntity_Entity>();
			for (int i = 0; i < _ctx.Length("DescribeAllEntity.EntityList.Length"); i++) {
				DescribeAllEntityResponse.DescribeAllEntity_Entity entity = new DescribeAllEntityResponse.DescribeAllEntity_Entity();
				entity.GroupId = _ctx.IntegerValue("DescribeAllEntity.EntityList["+ i +"].GroupId");
				entity.InstanceName = _ctx.StringValue("DescribeAllEntity.EntityList["+ i +"].InstanceName");
				entity.Ip = _ctx.StringValue("DescribeAllEntity.EntityList["+ i +"].Ip");
				entity.Uuid = _ctx.StringValue("DescribeAllEntity.EntityList["+ i +"].Uuid");
				entity.Os = _ctx.StringValue("DescribeAllEntity.EntityList["+ i +"].Os");
				entity.InternetIp = _ctx.StringValue("DescribeAllEntity.EntityList["+ i +"].InternetIp");
				entity.IntranetIp = _ctx.StringValue("DescribeAllEntity.EntityList["+ i +"].IntranetIp");

				describeAllEntityResponse_entityList.Add(entity);
			}
			describeAllEntityResponse.EntityList = describeAllEntityResponse_entityList;
        
			return describeAllEntityResponse;
        }
    }
}
