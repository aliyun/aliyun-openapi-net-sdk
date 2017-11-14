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
using Aliyun.Acs.live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeCasterConfigResponseUnmarshaller
    {
        public static DescribeCasterConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCasterConfigResponse describeCasterConfigResponse = new DescribeCasterConfigResponse();

			describeCasterConfigResponse.HttpResponse = context.HttpResponse;
			describeCasterConfigResponse.RequestId = context.StringValue("DescribeCasterConfig.RequestId");
			describeCasterConfigResponse.CasterId = context.StringValue("DescribeCasterConfig.CasterId");
			describeCasterConfigResponse.CasterName = context.StringValue("DescribeCasterConfig.CasterName");
			describeCasterConfigResponse.DomainName = context.StringValue("DescribeCasterConfig.DomainName");
			describeCasterConfigResponse.Delay = context.FloatValue("DescribeCasterConfig.Delay");
			describeCasterConfigResponse.UrgentMaterialId = context.StringValue("DescribeCasterConfig.UrgentMaterialId");

			DescribeCasterConfigResponse.DescribeCasterConfig_TranscodeConfig transcodeConfig = new DescribeCasterConfigResponse.DescribeCasterConfig_TranscodeConfig();
			transcodeConfig.CasterTemplate = context.StringValue("DescribeCasterConfig.TranscodeConfig.CasterTemplate");

			List<string> transcodeConfig_liveTemplateIds = new List<string>();
			for (int i = 0; i < context.Length("DescribeCasterConfig.TranscodeConfig.LiveTemplateIds.Length"); i++) {
				transcodeConfig_liveTemplateIds.Add(context.StringValue("DescribeCasterConfig.TranscodeConfig.LiveTemplateIds["+ i +"]"));
			}
			transcodeConfig.LiveTemplateIds = transcodeConfig_liveTemplateIds;
			describeCasterConfigResponse.TranscodeConfig = transcodeConfig;

			DescribeCasterConfigResponse.DescribeCasterConfig_RecordConfig recordConfig = new DescribeCasterConfigResponse.DescribeCasterConfig_RecordConfig();
			recordConfig.OssEndpoint = context.StringValue("DescribeCasterConfig.RecordConfig.OssEndpoint");
			recordConfig.OssBucket = context.StringValue("DescribeCasterConfig.RecordConfig.OssBucket");

			List<DescribeCasterConfigResponse.DescribeCasterConfig_RecordConfig.DescribeCasterConfig_RecordFormatItem> recordConfig_recordFormat = new List<DescribeCasterConfigResponse.DescribeCasterConfig_RecordConfig.DescribeCasterConfig_RecordFormatItem>();
			for (int i = 0; i < context.Length("DescribeCasterConfig.RecordConfig.RecordFormat.Length"); i++) {
				DescribeCasterConfigResponse.DescribeCasterConfig_RecordConfig.DescribeCasterConfig_RecordFormatItem recordFormatItem = new DescribeCasterConfigResponse.DescribeCasterConfig_RecordConfig.DescribeCasterConfig_RecordFormatItem();
				recordFormatItem.Format = context.StringValue("DescribeCasterConfig.RecordConfig.RecordFormat["+ i +"].Format");
				recordFormatItem.OssObjectPrefix = context.StringValue("DescribeCasterConfig.RecordConfig.RecordFormat["+ i +"].OssObjectPrefix");
				recordFormatItem.SliceOssObjectPrefix = context.StringValue("DescribeCasterConfig.RecordConfig.RecordFormat["+ i +"].SliceOssObjectPrefix");
				recordFormatItem.CycleDuration = context.IntegerValue("DescribeCasterConfig.RecordConfig.RecordFormat["+ i +"].CycleDuration");

				recordConfig_recordFormat.Add(recordFormatItem);
			}
			recordConfig.RecordFormat = recordConfig_recordFormat;
			describeCasterConfigResponse.RecordConfig = recordConfig;
        
			return describeCasterConfigResponse;
        }
    }
}