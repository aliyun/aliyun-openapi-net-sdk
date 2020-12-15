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
    public class DescribeDasInstanceConfigResponseUnmarshaller
    {
        public static DescribeDasInstanceConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDasInstanceConfigResponse describeDasInstanceConfigResponse = new DescribeDasInstanceConfigResponse();

			describeDasInstanceConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeDasInstanceConfigResponse.RequestId = _ctx.StringValue("DescribeDasInstanceConfig.RequestId");
			describeDasInstanceConfigResponse.Data = _ctx.StringValue("DescribeDasInstanceConfig.Data");
			describeDasInstanceConfigResponse.StorageUpperBound = _ctx.IntegerValue("DescribeDasInstanceConfig.StorageUpperBound");
			describeDasInstanceConfigResponse.MaxStorageUpperBound = _ctx.IntegerValue("DescribeDasInstanceConfig.MaxStorageUpperBound");
			describeDasInstanceConfigResponse.DBInstanceId = _ctx.StringValue("DescribeDasInstanceConfig.DBInstanceId");
			describeDasInstanceConfigResponse.StorageThreshold = _ctx.IntegerValue("DescribeDasInstanceConfig.StorageThreshold");
			describeDasInstanceConfigResponse.StorageAutoScale = _ctx.BooleanValue("DescribeDasInstanceConfig.StorageAutoScale");
			describeDasInstanceConfigResponse.DBType = _ctx.StringValue("DescribeDasInstanceConfig.DBType");
        
			return describeDasInstanceConfigResponse;
        }
    }
}
