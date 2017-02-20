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
using Aliyun.Acs.Cdn.Model.V20141111;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeLiveSnapshotConfigResponseUnmarshaller
    {
        public static DescribeLiveSnapshotConfigResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeLiveSnapshotConfigResponse describeLiveSnapshotConfigResponse = new DescribeLiveSnapshotConfigResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeLiveSnapshotConfig.RequestId"),
                PageNum = context.IntegerValue("DescribeLiveSnapshotConfig.PageNum"),
                PageSize = context.IntegerValue("DescribeLiveSnapshotConfig.PageSize"),
                Order = context.StringValue("DescribeLiveSnapshotConfig.Order"),
                TotalNum = context.IntegerValue("DescribeLiveSnapshotConfig.TotalNum"),
                TotalPage = context.IntegerValue("DescribeLiveSnapshotConfig.TotalPage")
            };
            List<DescribeLiveSnapshotConfigResponse.LiveStreamSnapshotConfig> liveStreamSnapshotConfigList = new List<DescribeLiveSnapshotConfigResponse.LiveStreamSnapshotConfig>();
			for (int i = 0; i < context.Length("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList.Length"); i++) {
                DescribeLiveSnapshotConfigResponse.LiveStreamSnapshotConfig liveStreamSnapshotConfig = new DescribeLiveSnapshotConfigResponse.LiveStreamSnapshotConfig()
                {
                    DomainName = context.StringValue($"DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList[{i}].DomainName"),
                    AppName = context.StringValue($"DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList[{i}].AppName"),
                    TimeInterval = context.IntegerValue($"DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList[{i}].TimeInterval"),
                    OssEndpoint = context.StringValue($"DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList[{i}].OssEndpoint"),
                    OssBucket = context.StringValue($"DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList[{i}].OssBucket"),
                    OverwriteOssObject = context.StringValue($"DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList[{i}].OverwriteOssObject"),
                    SequenceOssObject = context.StringValue($"DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList[{i}].SequenceOssObject"),
                    CreateTime = context.StringValue($"DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList[{i}].CreateTime")
                };
                liveStreamSnapshotConfigList.Add(liveStreamSnapshotConfig);
			}
			describeLiveSnapshotConfigResponse.LiveStreamSnapshotConfigList = liveStreamSnapshotConfigList;
        
			return describeLiveSnapshotConfigResponse;
        }
    }
}