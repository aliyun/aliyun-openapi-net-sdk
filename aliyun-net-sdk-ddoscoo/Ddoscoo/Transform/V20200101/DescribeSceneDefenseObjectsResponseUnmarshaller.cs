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
    public class DescribeSceneDefenseObjectsResponseUnmarshaller
    {
        public static DescribeSceneDefenseObjectsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSceneDefenseObjectsResponse describeSceneDefenseObjectsResponse = new DescribeSceneDefenseObjectsResponse();

			describeSceneDefenseObjectsResponse.HttpResponse = _ctx.HttpResponse;
			describeSceneDefenseObjectsResponse.RequestId = _ctx.StringValue("DescribeSceneDefenseObjects.RequestId");
			describeSceneDefenseObjectsResponse.Success = _ctx.BooleanValue("DescribeSceneDefenseObjects.Success");

			List<DescribeSceneDefenseObjectsResponse.DescribeSceneDefenseObjects__Object> describeSceneDefenseObjectsResponse_objects = new List<DescribeSceneDefenseObjectsResponse.DescribeSceneDefenseObjects__Object>();
			for (int i = 0; i < _ctx.Length("DescribeSceneDefenseObjects.Objects.Length"); i++) {
				DescribeSceneDefenseObjectsResponse.DescribeSceneDefenseObjects__Object _object = new DescribeSceneDefenseObjectsResponse.DescribeSceneDefenseObjects__Object();
				_object.PolicyId = _ctx.StringValue("DescribeSceneDefenseObjects.Objects["+ i +"].PolicyId");
				_object.Domain = _ctx.StringValue("DescribeSceneDefenseObjects.Objects["+ i +"].Domain");
				_object.Vip = _ctx.StringValue("DescribeSceneDefenseObjects.Objects["+ i +"].Vip");

				describeSceneDefenseObjectsResponse_objects.Add(_object);
			}
			describeSceneDefenseObjectsResponse.Objects = describeSceneDefenseObjectsResponse_objects;
        
			return describeSceneDefenseObjectsResponse;
        }
    }
}
