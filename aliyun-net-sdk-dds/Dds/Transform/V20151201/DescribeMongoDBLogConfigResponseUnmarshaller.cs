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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeMongoDBLogConfigResponseUnmarshaller
    {
        public static DescribeMongoDBLogConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMongoDBLogConfigResponse describeMongoDBLogConfigResponse = new DescribeMongoDBLogConfigResponse();

			describeMongoDBLogConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeMongoDBLogConfigResponse.UserProjectName = _ctx.StringValue("DescribeMongoDBLogConfig.UserProjectName");
			describeMongoDBLogConfigResponse.RequestId = _ctx.StringValue("DescribeMongoDBLogConfig.RequestId");
			describeMongoDBLogConfigResponse.IsUserProjectLogstoreExist = _ctx.IntegerValue("DescribeMongoDBLogConfig.IsUserProjectLogstoreExist");
			describeMongoDBLogConfigResponse.IsEtlMetaExist = _ctx.IntegerValue("DescribeMongoDBLogConfig.IsEtlMetaExist");
			describeMongoDBLogConfigResponse.ServiceType = _ctx.StringValue("DescribeMongoDBLogConfig.ServiceType");
			describeMongoDBLogConfigResponse.EnableAudit = _ctx.BooleanValue("DescribeMongoDBLogConfig.EnableAudit");
			describeMongoDBLogConfigResponse.TtlForTrail = _ctx.LongValue("DescribeMongoDBLogConfig.TtlForTrail");
			describeMongoDBLogConfigResponse.UsedStorageForTrail = _ctx.LongValue("DescribeMongoDBLogConfig.UsedStorageForTrail");
			describeMongoDBLogConfigResponse.PreserveStorageForTrail = _ctx.LongValue("DescribeMongoDBLogConfig.PreserveStorageForTrail");
			describeMongoDBLogConfigResponse.TtlForStandard = _ctx.LongValue("DescribeMongoDBLogConfig.TtlForStandard");
			describeMongoDBLogConfigResponse.UsedStorageForStandard = _ctx.LongValue("DescribeMongoDBLogConfig.UsedStorageForStandard");
			describeMongoDBLogConfigResponse.PreserveStorageForStandard = _ctx.LongValue("DescribeMongoDBLogConfig.PreserveStorageForStandard");
        
			return describeMongoDBLogConfigResponse;
        }
    }
}
