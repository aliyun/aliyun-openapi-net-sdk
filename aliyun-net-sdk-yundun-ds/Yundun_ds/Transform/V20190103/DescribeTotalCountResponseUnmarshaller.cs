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
using Aliyun.Acs.Yundun_ds.Model.V20190103;

namespace Aliyun.Acs.Yundun_ds.Transform.V20190103
{
    public class DescribeTotalCountResponseUnmarshaller
    {
        public static DescribeTotalCountResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTotalCountResponse describeTotalCountResponse = new DescribeTotalCountResponse();

			describeTotalCountResponse.HttpResponse = context.HttpResponse;
			describeTotalCountResponse.RequestId = context.StringValue("DescribeTotalCount.RequestId");

			DescribeTotalCountResponse.DescribeTotalCount_DataCount dataCount = new DescribeTotalCountResponse.DescribeTotalCount_DataCount();

			DescribeTotalCountResponse.DescribeTotalCount_DataCount.DescribeTotalCount_Instance instance = new DescribeTotalCountResponse.DescribeTotalCount_DataCount.DescribeTotalCount_Instance();
			instance.TotalCount = context.LongValue("DescribeTotalCount.DataCount.Instance.TotalCount");
			instance.Count = context.LongValue("DescribeTotalCount.DataCount.Instance.Count");
			instance.SensitiveCount = context.LongValue("DescribeTotalCount.DataCount.Instance.SensitiveCount");
			instance.LastCount = context.LongValue("DescribeTotalCount.DataCount.Instance.LastCount");
			instance.LastSensitiveCount = context.LongValue("DescribeTotalCount.DataCount.Instance.LastSensitiveCount");
			dataCount.Instance = instance;

			DescribeTotalCountResponse.DescribeTotalCount_DataCount.DescribeTotalCount_Table table = new DescribeTotalCountResponse.DescribeTotalCount_DataCount.DescribeTotalCount_Table();
			table.TotalCount = context.LongValue("DescribeTotalCount.DataCount.Table.TotalCount");
			table.Count = context.LongValue("DescribeTotalCount.DataCount.Table.Count");
			table.SensitiveCount = context.LongValue("DescribeTotalCount.DataCount.Table.SensitiveCount");
			table.LastCount = context.LongValue("DescribeTotalCount.DataCount.Table.LastCount");
			table.LastSensitiveCount = context.LongValue("DescribeTotalCount.DataCount.Table.LastSensitiveCount");
			dataCount.Table = table;

			DescribeTotalCountResponse.DescribeTotalCount_DataCount.DescribeTotalCount_Oss oss = new DescribeTotalCountResponse.DescribeTotalCount_DataCount.DescribeTotalCount_Oss();
			oss.TotalCount = context.LongValue("DescribeTotalCount.DataCount.Oss.TotalCount");
			oss.Count = context.LongValue("DescribeTotalCount.DataCount.Oss.Count");
			oss.SensitiveCount = context.LongValue("DescribeTotalCount.DataCount.Oss.SensitiveCount");
			oss.LastCount = context.LongValue("DescribeTotalCount.DataCount.Oss.LastCount");
			oss.LastSensitiveCount = context.LongValue("DescribeTotalCount.DataCount.Oss.LastSensitiveCount");
			dataCount.Oss = oss;
			describeTotalCountResponse.DataCount = dataCount;

			DescribeTotalCountResponse.DescribeTotalCount_EventCount eventCount = new DescribeTotalCountResponse.DescribeTotalCount_EventCount();

			DescribeTotalCountResponse.DescribeTotalCount_EventCount.DescribeTotalCount_Total total = new DescribeTotalCountResponse.DescribeTotalCount_EventCount.DescribeTotalCount_Total();
			total.TotalCount = context.LongValue("DescribeTotalCount.EventCount.Total.TotalCount");
			total.UndealCount = context.LongValue("DescribeTotalCount.EventCount.Total.UndealCount");
			total.ConfirmCount = context.LongValue("DescribeTotalCount.EventCount.Total.ConfirmCount");
			total.ExcludeCount = context.LongValue("DescribeTotalCount.EventCount.Total.ExcludeCount");
			eventCount.Total = total;
			describeTotalCountResponse.EventCount = eventCount;

			DescribeTotalCountResponse.DescribeTotalCount_DepartCount departCount = new DescribeTotalCountResponse.DescribeTotalCount_DepartCount();
			departCount.DepartCount = context.LongValue("DescribeTotalCount.DepartCount.DepartCount");
			departCount.Count = context.LongValue("DescribeTotalCount.DepartCount.Count");
			departCount.UserCount = context.LongValue("DescribeTotalCount.DepartCount.UserCount");
			departCount.DtCount = context.LongValue("DescribeTotalCount.DepartCount.DtCount");
			departCount.SubCount = context.LongValue("DescribeTotalCount.DepartCount.SubCount");
			departCount.SensitiveCount = context.LongValue("DescribeTotalCount.DepartCount.SensitiveCount");
			describeTotalCountResponse.DepartCount = departCount;
        
			return describeTotalCountResponse;
        }
    }
}
