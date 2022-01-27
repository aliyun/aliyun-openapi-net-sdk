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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class QueryRegionConfigResponseUnmarshaller
    {
        public static QueryRegionConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryRegionConfigResponse queryRegionConfigResponse = new QueryRegionConfigResponse();

			queryRegionConfigResponse.HttpResponse = _ctx.HttpResponse;
			queryRegionConfigResponse.RequestId = _ctx.StringValue("QueryRegionConfig.RequestId");
			queryRegionConfigResponse.Code = _ctx.IntegerValue("QueryRegionConfig.Code");
			queryRegionConfigResponse.Message = _ctx.StringValue("QueryRegionConfig.Message");

			QueryRegionConfigResponse.QueryRegionConfig_RegionConfig regionConfig = new QueryRegionConfigResponse.QueryRegionConfig_RegionConfig();
			regionConfig.AddressServerHost = _ctx.StringValue("QueryRegionConfig.RegionConfig.AddressServerHost");
			regionConfig.AgentInstallScript = _ctx.StringValue("QueryRegionConfig.RegionConfig.AgentInstallScript");
			regionConfig.FileServerType = _ctx.StringValue("QueryRegionConfig.RegionConfig.FileServerType");
			regionConfig.Id = _ctx.StringValue("QueryRegionConfig.RegionConfig.Id");
			regionConfig.ImageId = _ctx.StringValue("QueryRegionConfig.RegionConfig.ImageId");
			regionConfig.Name = _ctx.StringValue("QueryRegionConfig.RegionConfig.Name");
			regionConfig.No = _ctx.IntegerValue("QueryRegionConfig.RegionConfig.No");
			regionConfig.Tag = _ctx.StringValue("QueryRegionConfig.RegionConfig.Tag");

			QueryRegionConfigResponse.QueryRegionConfig_RegionConfig.QueryRegionConfig_FileServerConfig fileServerConfig = new QueryRegionConfigResponse.QueryRegionConfig_RegionConfig.QueryRegionConfig_FileServerConfig();
			fileServerConfig.Bucket = _ctx.StringValue("QueryRegionConfig.RegionConfig.FileServerConfig.Bucket");
			fileServerConfig.InternalUrl = _ctx.StringValue("QueryRegionConfig.RegionConfig.FileServerConfig.InternalUrl");
			fileServerConfig.PublicUrl = _ctx.StringValue("QueryRegionConfig.RegionConfig.FileServerConfig.PublicUrl");
			fileServerConfig.VpcUrl = _ctx.StringValue("QueryRegionConfig.RegionConfig.FileServerConfig.VpcUrl");
			regionConfig.FileServerConfig = fileServerConfig;
			queryRegionConfigResponse.RegionConfig = regionConfig;
        
			return queryRegionConfigResponse;
        }
    }
}
