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
using Aliyun.Acs.Ecs.Model.V20151101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20151101
{
    public class OpsMigrateEcsInstanceResponseUnmarshaller
    {
        public static OpsMigrateEcsInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			OpsMigrateEcsInstanceResponse opsMigrateEcsInstanceResponse = new OpsMigrateEcsInstanceResponse();

			opsMigrateEcsInstanceResponse.HttpResponse = context.HttpResponse;
			opsMigrateEcsInstanceResponse.RequestId = context.StringValue("OpsMigrateEcsInstance.RequestId");
			opsMigrateEcsInstanceResponse.EcsInstanceId = context.StringValue("OpsMigrateEcsInstance.EcsInstanceId");
			opsMigrateEcsInstanceResponse.Status = context.StringValue("OpsMigrateEcsInstance.Status");
			opsMigrateEcsInstanceResponse.NcId = context.StringValue("OpsMigrateEcsInstance.NcId");
        
			return opsMigrateEcsInstanceResponse;
        }
    }
}