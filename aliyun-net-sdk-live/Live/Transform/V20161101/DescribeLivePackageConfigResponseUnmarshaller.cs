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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLivePackageConfigResponseUnmarshaller
    {
        public static DescribeLivePackageConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLivePackageConfigResponse describeLivePackageConfigResponse = new DescribeLivePackageConfigResponse();

			describeLivePackageConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeLivePackageConfigResponse.Order = _ctx.StringValue("DescribeLivePackageConfig.Order");
			describeLivePackageConfigResponse.PageNum = _ctx.IntegerValue("DescribeLivePackageConfig.PageNum");
			describeLivePackageConfigResponse.PageSize = _ctx.IntegerValue("DescribeLivePackageConfig.PageSize");
			describeLivePackageConfigResponse.RequestId = _ctx.StringValue("DescribeLivePackageConfig.RequestId");
			describeLivePackageConfigResponse.TotalNum = _ctx.IntegerValue("DescribeLivePackageConfig.TotalNum");
			describeLivePackageConfigResponse.TotalPage = _ctx.IntegerValue("DescribeLivePackageConfig.TotalPage");

			List<DescribeLivePackageConfigResponse.DescribeLivePackageConfig_LivePackageConfig> describeLivePackageConfigResponse_livePackageConfigList = new List<DescribeLivePackageConfigResponse.DescribeLivePackageConfig_LivePackageConfig>();
			for (int i = 0; i < _ctx.Length("DescribeLivePackageConfig.LivePackageConfigList.Length"); i++) {
				DescribeLivePackageConfigResponse.DescribeLivePackageConfig_LivePackageConfig livePackageConfig = new DescribeLivePackageConfigResponse.DescribeLivePackageConfig_LivePackageConfig();
				livePackageConfig.AppName = _ctx.StringValue("DescribeLivePackageConfig.LivePackageConfigList["+ i +"].AppName");
				livePackageConfig.DomainName = _ctx.StringValue("DescribeLivePackageConfig.LivePackageConfigList["+ i +"].DomainName");
				livePackageConfig.IgnoreTranscode = _ctx.BooleanValue("DescribeLivePackageConfig.LivePackageConfigList["+ i +"].IgnoreTranscode");
				livePackageConfig.PartDuration = _ctx.IntegerValue("DescribeLivePackageConfig.LivePackageConfigList["+ i +"].PartDuration");
				livePackageConfig.Protocol = _ctx.StringValue("DescribeLivePackageConfig.LivePackageConfigList["+ i +"].Protocol");
				livePackageConfig.SegmentDuration = _ctx.IntegerValue("DescribeLivePackageConfig.LivePackageConfigList["+ i +"].SegmentDuration");
				livePackageConfig.SegmentNum = _ctx.IntegerValue("DescribeLivePackageConfig.LivePackageConfigList["+ i +"].SegmentNum");
				livePackageConfig.StreamName = _ctx.StringValue("DescribeLivePackageConfig.LivePackageConfigList["+ i +"].StreamName");

				describeLivePackageConfigResponse_livePackageConfigList.Add(livePackageConfig);
			}
			describeLivePackageConfigResponse.LivePackageConfigList = describeLivePackageConfigResponse_livePackageConfigList;
        
			return describeLivePackageConfigResponse;
        }
    }
}
