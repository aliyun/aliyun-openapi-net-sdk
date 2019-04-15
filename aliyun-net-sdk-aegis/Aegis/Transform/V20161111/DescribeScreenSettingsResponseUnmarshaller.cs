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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeScreenSettingsResponseUnmarshaller
    {
        public static DescribeScreenSettingsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScreenSettingsResponse describeScreenSettingsResponse = new DescribeScreenSettingsResponse();

			describeScreenSettingsResponse.HttpResponse = context.HttpResponse;
			describeScreenSettingsResponse.RequestId = context.StringValue("DescribeScreenSettings.RequestId");
			describeScreenSettingsResponse.RequestId1 = context.StringValue("DescribeScreenSettings.RequestId");

			List<DescribeScreenSettingsResponse.DescribeScreenSettings_SasScreenSettingListItem> describeScreenSettingsResponse_sasScreenSettingList = new List<DescribeScreenSettingsResponse.DescribeScreenSettings_SasScreenSettingListItem>();
			for (int i = 0; i < context.Length("DescribeScreenSettings.SasScreenSettingList.Length"); i++) {
				DescribeScreenSettingsResponse.DescribeScreenSettings_SasScreenSettingListItem sasScreenSettingListItem = new DescribeScreenSettingsResponse.DescribeScreenSettings_SasScreenSettingListItem();
				sasScreenSettingListItem.ScreenSettingTitle = context.StringValue("DescribeScreenSettings.SasScreenSettingList["+ i +"].ScreenSettingTitle");
				sasScreenSettingListItem.ScreenSettingIdMap = context.StringValue("DescribeScreenSettings.SasScreenSettingList["+ i +"].ScreenSettingIdMap");

				describeScreenSettingsResponse_sasScreenSettingList.Add(sasScreenSettingListItem);
			}
			describeScreenSettingsResponse.SasScreenSettingList = describeScreenSettingsResponse_sasScreenSettingList;
        
			return describeScreenSettingsResponse;
        }
    }
}
