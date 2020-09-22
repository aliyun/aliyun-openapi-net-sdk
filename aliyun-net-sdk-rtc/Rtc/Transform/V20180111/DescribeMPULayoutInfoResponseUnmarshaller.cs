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
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeMPULayoutInfoResponseUnmarshaller
    {
        public static DescribeMPULayoutInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMPULayoutInfoResponse describeMPULayoutInfoResponse = new DescribeMPULayoutInfoResponse();

			describeMPULayoutInfoResponse.HttpResponse = context.HttpResponse;
			describeMPULayoutInfoResponse.RequestId = context.StringValue("DescribeMPULayoutInfo.RequestId");

			DescribeMPULayoutInfoResponse.DescribeMPULayoutInfo_Layout layout = new DescribeMPULayoutInfoResponse.DescribeMPULayoutInfo_Layout();
			layout.LayoutId = context.LongValue("DescribeMPULayoutInfo.Layout.LayoutId");
			layout.AudioMixCount = context.IntegerValue("DescribeMPULayoutInfo.Layout.AudioMixCount");

			List<DescribeMPULayoutInfoResponse.DescribeMPULayoutInfo_Layout.DescribeMPULayoutInfo_PanesItem> layout_panes = new List<DescribeMPULayoutInfoResponse.DescribeMPULayoutInfo_Layout.DescribeMPULayoutInfo_PanesItem>();
			for (int i = 0; i < context.Length("DescribeMPULayoutInfo.Layout.Panes.Length"); i++) {
				DescribeMPULayoutInfoResponse.DescribeMPULayoutInfo_Layout.DescribeMPULayoutInfo_PanesItem panesItem = new DescribeMPULayoutInfoResponse.DescribeMPULayoutInfo_Layout.DescribeMPULayoutInfo_PanesItem();
				panesItem.PaneId = context.IntegerValue("DescribeMPULayoutInfo.Layout.Panes["+ i +"].PaneId");
				panesItem.MajorPane = context.IntegerValue("DescribeMPULayoutInfo.Layout.Panes["+ i +"].MajorPane");
				panesItem.X = context.FloatValue("DescribeMPULayoutInfo.Layout.Panes["+ i +"].X");
				panesItem.Y = context.FloatValue("DescribeMPULayoutInfo.Layout.Panes["+ i +"].Y");
				panesItem.Width = context.FloatValue("DescribeMPULayoutInfo.Layout.Panes["+ i +"].Width");
				panesItem.Height = context.FloatValue("DescribeMPULayoutInfo.Layout.Panes["+ i +"].Height");
				panesItem.ZOrder = context.IntegerValue("DescribeMPULayoutInfo.Layout.Panes["+ i +"].ZOrder");

				layout_panes.Add(panesItem);
			}
			layout.Panes = layout_panes;
			describeMPULayoutInfoResponse.Layout = layout;
        
			return describeMPULayoutInfoResponse;
        }
    }
}
