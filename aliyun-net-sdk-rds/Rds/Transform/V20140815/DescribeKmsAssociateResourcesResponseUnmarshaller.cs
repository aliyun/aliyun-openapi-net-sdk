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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeKmsAssociateResourcesResponseUnmarshaller
    {
        public static DescribeKmsAssociateResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeKmsAssociateResourcesResponse describeKmsAssociateResourcesResponse = new DescribeKmsAssociateResourcesResponse();

			describeKmsAssociateResourcesResponse.HttpResponse = _ctx.HttpResponse;
			describeKmsAssociateResourcesResponse.RequestId = _ctx.StringValue("DescribeKmsAssociateResources.RequestId");
			describeKmsAssociateResourcesResponse.AssociateStatus = _ctx.BooleanValue("DescribeKmsAssociateResources.AssociateStatus");

			List<DescribeKmsAssociateResourcesResponse.DescribeKmsAssociateResources_DBInstance> describeKmsAssociateResourcesResponse_associateDBInstances = new List<DescribeKmsAssociateResourcesResponse.DescribeKmsAssociateResources_DBInstance>();
			for (int i = 0; i < _ctx.Length("DescribeKmsAssociateResources.AssociateDBInstances.Length"); i++) {
				DescribeKmsAssociateResourcesResponse.DescribeKmsAssociateResources_DBInstance dBInstance = new DescribeKmsAssociateResourcesResponse.DescribeKmsAssociateResources_DBInstance();
				dBInstance.DBInstanceName = _ctx.StringValue("DescribeKmsAssociateResources.AssociateDBInstances["+ i +"].DBInstanceName");
				dBInstance.Engine = _ctx.StringValue("DescribeKmsAssociateResources.AssociateDBInstances["+ i +"].Engine");
				dBInstance.Status = _ctx.StringValue("DescribeKmsAssociateResources.AssociateDBInstances["+ i +"].Status");
				dBInstance.KeyUsedBy = _ctx.StringValue("DescribeKmsAssociateResources.AssociateDBInstances["+ i +"].KeyUsedBy");

				describeKmsAssociateResourcesResponse_associateDBInstances.Add(dBInstance);
			}
			describeKmsAssociateResourcesResponse.AssociateDBInstances = describeKmsAssociateResourcesResponse_associateDBInstances;
        
			return describeKmsAssociateResourcesResponse;
        }
    }
}
