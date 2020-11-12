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
using Aliyun.Acs.Actiontrail.Model.V20171204;

namespace Aliyun.Acs.Actiontrail.Transform.V20171204
{
    public class CreateTrailResponseUnmarshaller
    {
        public static CreateTrailResponse Unmarshall(UnmarshallerContext context)
        {
			CreateTrailResponse createTrailResponse = new CreateTrailResponse();

			createTrailResponse.HttpResponse = context.HttpResponse;
			createTrailResponse.RequestId = context.StringValue("CreateTrail.RequestId");
			createTrailResponse.Name = context.StringValue("CreateTrail.Name");
			createTrailResponse.HomeRegion = context.StringValue("CreateTrail.HomeRegion");
			createTrailResponse.OssBucketName = context.StringValue("CreateTrail.OssBucketName");
			createTrailResponse.OssKeyPrefix = context.StringValue("CreateTrail.OssKeyPrefix");
			createTrailResponse.RoleName = context.StringValue("CreateTrail.RoleName");
			createTrailResponse.SlsProjectArn = context.StringValue("CreateTrail.SlsProjectArn");
			createTrailResponse.SlsWriteRoleArn = context.StringValue("CreateTrail.SlsWriteRoleArn");
			createTrailResponse.EventRW = context.StringValue("CreateTrail.EventRW");
			createTrailResponse.TrailRegion = context.StringValue("CreateTrail.TrailRegion");
			createTrailResponse.MnsTopicArn = context.StringValue("CreateTrail.MnsTopicArn");
        
			return createTrailResponse;
        }
    }
}
