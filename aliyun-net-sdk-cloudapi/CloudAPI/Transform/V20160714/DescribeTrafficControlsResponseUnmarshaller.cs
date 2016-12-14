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
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeTrafficControlsResponseUnmarshaller
    {
        public static DescribeTrafficControlsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTrafficControlsResponse describeTrafficControlsResponse = new DescribeTrafficControlsResponse();

			describeTrafficControlsResponse.HttpResponse = context.HttpResponse;
			describeTrafficControlsResponse.RequestId = context.StringValue("DescribeTrafficControls.RequestId");
			describeTrafficControlsResponse.TotalCount = context.IntegerValue("DescribeTrafficControls.TotalCount");
			describeTrafficControlsResponse.PageSize = context.IntegerValue("DescribeTrafficControls.PageSize");
			describeTrafficControlsResponse.PageNumber = context.IntegerValue("DescribeTrafficControls.PageNumber");

			List<DescribeTrafficControlsResponse.TrafficControl> trafficControls = new List<DescribeTrafficControlsResponse.TrafficControl>();
			for (int i = 0; i < context.Length("DescribeTrafficControls.TrafficControls.Length"); i++) {
				DescribeTrafficControlsResponse.TrafficControl trafficControl = new DescribeTrafficControlsResponse.TrafficControl();
				trafficControl.TrafficControlId = context.StringValue("DescribeTrafficControls.TrafficControls["+ i +"].TrafficControlId");
				trafficControl.TrafficControlName = context.StringValue("DescribeTrafficControls.TrafficControls["+ i +"].TrafficControlName");
				trafficControl.Description = context.StringValue("DescribeTrafficControls.TrafficControls["+ i +"].Description");
				trafficControl.TrafficControlUnit = context.StringValue("DescribeTrafficControls.TrafficControls["+ i +"].TrafficControlUnit");
				trafficControl.ApiDefault = context.IntegerValue("DescribeTrafficControls.TrafficControls["+ i +"].ApiDefault");
				trafficControl.UserDefault = context.IntegerValue("DescribeTrafficControls.TrafficControls["+ i +"].UserDefault");
				trafficControl.AppDefault = context.IntegerValue("DescribeTrafficControls.TrafficControls["+ i +"].AppDefault");
				trafficControl.CreatedTime = context.StringValue("DescribeTrafficControls.TrafficControls["+ i +"].CreatedTime");
				trafficControl.ModifiedTime = context.StringValue("DescribeTrafficControls.TrafficControls["+ i +"].ModifiedTime");

				List<DescribeTrafficControlsResponse.TrafficControl.SpecialPolicy> specialPolicies = new List<DescribeTrafficControlsResponse.TrafficControl.SpecialPolicy>();
				for (int j = 0; j < context.Length("DescribeTrafficControls.TrafficControls["+ i +"].SpecialPolicies.Length"); j++) {
					DescribeTrafficControlsResponse.TrafficControl.SpecialPolicy specialPolicy = new DescribeTrafficControlsResponse.TrafficControl.SpecialPolicy();
					specialPolicy.SpecialType = context.StringValue("DescribeTrafficControls.TrafficControls["+ i +"].SpecialPolicies["+ j +"].SpecialType");

					List<DescribeTrafficControlsResponse.TrafficControl.SpecialPolicy.Special> specials = new List<DescribeTrafficControlsResponse.TrafficControl.SpecialPolicy.Special>();
					for (int k = 0; k < context.Length("DescribeTrafficControls.TrafficControls["+ i +"].SpecialPolicies["+ j +"].Specials.Length"); k++) {
						DescribeTrafficControlsResponse.TrafficControl.SpecialPolicy.Special special = new DescribeTrafficControlsResponse.TrafficControl.SpecialPolicy.Special();
						special.SpecialKey = context.StringValue("DescribeTrafficControls.TrafficControls["+ i +"].SpecialPolicies["+ j +"].Specials["+ k +"].SpecialKey");
						special.TrafficValue = context.IntegerValue("DescribeTrafficControls.TrafficControls["+ i +"].SpecialPolicies["+ j +"].Specials["+ k +"].TrafficValue");

						specials.Add(special);
					}
					specialPolicy.Specials = specials;

					specialPolicies.Add(specialPolicy);
				}
				trafficControl.SpecialPolicies = specialPolicies;

				trafficControls.Add(trafficControl);
			}
			describeTrafficControlsResponse.TrafficControls = trafficControls;
        
			return describeTrafficControlsResponse;
        }
    }
}