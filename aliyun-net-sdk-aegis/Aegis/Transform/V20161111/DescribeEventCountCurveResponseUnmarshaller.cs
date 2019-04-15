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
    public class DescribeEventCountCurveResponseUnmarshaller
    {
        public static DescribeEventCountCurveResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEventCountCurveResponse describeEventCountCurveResponse = new DescribeEventCountCurveResponse();

			describeEventCountCurveResponse.HttpResponse = context.HttpResponse;
			describeEventCountCurveResponse.RequestId = context.StringValue("DescribeEventCountCurve.RequestId");
			describeEventCountCurveResponse.Success = context.BooleanValue("DescribeEventCountCurve.Success");

			DescribeEventCountCurveResponse.DescribeEventCountCurve_CurveData curveData = new DescribeEventCountCurveResponse.DescribeEventCountCurve_CurveData();

			DescribeEventCountCurveResponse.DescribeEventCountCurve_CurveData.DescribeEventCountCurve_TimeScope timeScope = new DescribeEventCountCurveResponse.DescribeEventCountCurve_CurveData.DescribeEventCountCurve_TimeScope();
			timeScope.Start = context.LongValue("DescribeEventCountCurve.CurveData.TimeScope.Start");
			timeScope.End = context.LongValue("DescribeEventCountCurve.CurveData.TimeScope.End");
			timeScope.Interval = context.IntegerValue("DescribeEventCountCurve.CurveData.TimeScope.Interval");
			timeScope.Step = context.IntegerValue("DescribeEventCountCurve.CurveData.TimeScope.Step");
			curveData.TimeScope = timeScope;

			List<DescribeEventCountCurveResponse.DescribeEventCountCurve_CurveData.DescribeEventCountCurve_Item> curveData_items = new List<DescribeEventCountCurveResponse.DescribeEventCountCurve_CurveData.DescribeEventCountCurve_Item>();
			for (int i = 0; i < context.Length("DescribeEventCountCurve.CurveData.Items.Length"); i++) {
				DescribeEventCountCurveResponse.DescribeEventCountCurve_CurveData.DescribeEventCountCurve_Item item = new DescribeEventCountCurveResponse.DescribeEventCountCurve_CurveData.DescribeEventCountCurve_Item();
				item.Name = context.StringValue("DescribeEventCountCurve.CurveData.Items["+ i +"].Name");

				List<DescribeEventCountCurveResponse.DescribeEventCountCurve_CurveData.DescribeEventCountCurve_Item.DescribeEventCountCurve_DataItem> item_data = new List<DescribeEventCountCurveResponse.DescribeEventCountCurve_CurveData.DescribeEventCountCurve_Item.DescribeEventCountCurve_DataItem>();
				for (int j = 0; j < context.Length("DescribeEventCountCurve.CurveData.Items["+ i +"].Data.Length"); j++) {
					DescribeEventCountCurveResponse.DescribeEventCountCurve_CurveData.DescribeEventCountCurve_Item.DescribeEventCountCurve_DataItem dataItem = new DescribeEventCountCurveResponse.DescribeEventCountCurve_CurveData.DescribeEventCountCurve_Item.DescribeEventCountCurve_DataItem();
					dataItem.High = context.IntegerValue("DescribeEventCountCurve.CurveData.Items["+ i +"].Data["+ j +"].High");
					dataItem.Total = context.IntegerValue("DescribeEventCountCurve.CurveData.Items["+ i +"].Data["+ j +"].Total");
					dataItem.Low = context.IntegerValue("DescribeEventCountCurve.CurveData.Items["+ i +"].Data["+ j +"].Low");
					dataItem.Serious = context.IntegerValue("DescribeEventCountCurve.CurveData.Items["+ i +"].Data["+ j +"].Serious");
					dataItem.Suspicious = context.IntegerValue("DescribeEventCountCurve.CurveData.Items["+ i +"].Data["+ j +"].Suspicious");
					dataItem.Remind = context.IntegerValue("DescribeEventCountCurve.CurveData.Items["+ i +"].Data["+ j +"].Remind");
					dataItem.Medium = context.IntegerValue("DescribeEventCountCurve.CurveData.Items["+ i +"].Data["+ j +"].Medium");

					item_data.Add(dataItem);
				}
				item.Data = item_data;

				curveData_items.Add(item);
			}
			curveData.Items = curveData_items;
			describeEventCountCurveResponse.CurveData = curveData;
        
			return describeEventCountCurveResponse;
        }
    }
}
