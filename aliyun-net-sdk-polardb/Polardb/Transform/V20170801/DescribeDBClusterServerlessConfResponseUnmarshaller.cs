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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeDBClusterServerlessConfResponseUnmarshaller
    {
        public static DescribeDBClusterServerlessConfResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterServerlessConfResponse describeDBClusterServerlessConfResponse = new DescribeDBClusterServerlessConfResponse();

			describeDBClusterServerlessConfResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterServerlessConfResponse.RequestId = _ctx.StringValue("DescribeDBClusterServerlessConf.RequestId");
			describeDBClusterServerlessConfResponse.ScaleMin = _ctx.StringValue("DescribeDBClusterServerlessConf.ScaleMin");
			describeDBClusterServerlessConfResponse.ScaleMax = _ctx.StringValue("DescribeDBClusterServerlessConf.ScaleMax");
			describeDBClusterServerlessConfResponse.ScaleRoNumMin = _ctx.StringValue("DescribeDBClusterServerlessConf.ScaleRoNumMin");
			describeDBClusterServerlessConfResponse.ScaleRoNumMax = _ctx.StringValue("DescribeDBClusterServerlessConf.ScaleRoNumMax");
			describeDBClusterServerlessConfResponse.AllowShutDown = _ctx.StringValue("DescribeDBClusterServerlessConf.AllowShutDown");
			describeDBClusterServerlessConfResponse.SecondsUntilAutoPause = _ctx.StringValue("DescribeDBClusterServerlessConf.SecondsUntilAutoPause");
			describeDBClusterServerlessConfResponse.DBClusterId = _ctx.StringValue("DescribeDBClusterServerlessConf.DBClusterId");
			describeDBClusterServerlessConfResponse.ScaleApRoNumMin = _ctx.StringValue("DescribeDBClusterServerlessConf.ScaleApRoNumMin");
			describeDBClusterServerlessConfResponse.ScaleApRoNumMax = _ctx.StringValue("DescribeDBClusterServerlessConf.ScaleApRoNumMax");
			describeDBClusterServerlessConfResponse.Switchs = _ctx.StringValue("DescribeDBClusterServerlessConf.Switchs");
			describeDBClusterServerlessConfResponse.DBMaxscaleId = _ctx.StringValue("DescribeDBClusterServerlessConf.DBMaxscaleId");
        
			return describeDBClusterServerlessConfResponse;
        }
    }
}
