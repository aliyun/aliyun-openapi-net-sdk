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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class GenerateBasicStatisticsReportResponseUnmarshaller
    {
        public static GenerateBasicStatisticsReportResponse Unmarshall(UnmarshallerContext context)
        {
			GenerateBasicStatisticsReportResponse generateBasicStatisticsReportResponse = new GenerateBasicStatisticsReportResponse();

			generateBasicStatisticsReportResponse.HttpResponse = context.HttpResponse;
			generateBasicStatisticsReportResponse.RequestId = context.StringValue("GenerateBasicStatisticsReport.RequestId");
			generateBasicStatisticsReportResponse.Success = context.BooleanValue("GenerateBasicStatisticsReport.Success");
			generateBasicStatisticsReportResponse.Code = context.StringValue("GenerateBasicStatisticsReport.Code");
			generateBasicStatisticsReportResponse.Message = context.StringValue("GenerateBasicStatisticsReport.Message");
			generateBasicStatisticsReportResponse.HttpStatusCode = context.IntegerValue("GenerateBasicStatisticsReport.HttpStatusCode");

			GenerateBasicStatisticsReportResponse.GenerateBasicStatisticsReport_BasicStatisticsReport basicStatisticsReport = new GenerateBasicStatisticsReportResponse.GenerateBasicStatisticsReport_BasicStatisticsReport();

			List<GenerateBasicStatisticsReportResponse.GenerateBasicStatisticsReport_BasicStatisticsReport.GenerateBasicStatisticsReport_BasicStatisticsReportItem> basicStatisticsReport_items = new List<GenerateBasicStatisticsReportResponse.GenerateBasicStatisticsReport_BasicStatisticsReport.GenerateBasicStatisticsReport_BasicStatisticsReportItem>();
			for (int i = 0; i < context.Length("GenerateBasicStatisticsReport.BasicStatisticsReport.Items.Length"); i++) {
				GenerateBasicStatisticsReportResponse.GenerateBasicStatisticsReport_BasicStatisticsReport.GenerateBasicStatisticsReport_BasicStatisticsReportItem basicStatisticsReportItem = new GenerateBasicStatisticsReportResponse.GenerateBasicStatisticsReport_BasicStatisticsReport.GenerateBasicStatisticsReport_BasicStatisticsReportItem();
				basicStatisticsReportItem.Title = context.StringValue("GenerateBasicStatisticsReport.BasicStatisticsReport.Items["+ i +"].Title");
				basicStatisticsReportItem.TotalCount = context.IntegerValue("GenerateBasicStatisticsReport.BasicStatisticsReport.Items["+ i +"].TotalCount");
				basicStatisticsReportItem.GraphType = context.StringValue("GenerateBasicStatisticsReport.BasicStatisticsReport.Items["+ i +"].GraphType");

				List<GenerateBasicStatisticsReportResponse.GenerateBasicStatisticsReport_BasicStatisticsReport.GenerateBasicStatisticsReport_BasicStatisticsReportItem.GenerateBasicStatisticsReport_BasicStatisticsReportSubItem> basicStatisticsReportItem_subItems = new List<GenerateBasicStatisticsReportResponse.GenerateBasicStatisticsReport_BasicStatisticsReport.GenerateBasicStatisticsReport_BasicStatisticsReportItem.GenerateBasicStatisticsReport_BasicStatisticsReportSubItem>();
				for (int j = 0; j < context.Length("GenerateBasicStatisticsReport.BasicStatisticsReport.Items["+ i +"].SubItems.Length"); j++) {
					GenerateBasicStatisticsReportResponse.GenerateBasicStatisticsReport_BasicStatisticsReport.GenerateBasicStatisticsReport_BasicStatisticsReportItem.GenerateBasicStatisticsReport_BasicStatisticsReportSubItem basicStatisticsReportSubItem = new GenerateBasicStatisticsReportResponse.GenerateBasicStatisticsReport_BasicStatisticsReport.GenerateBasicStatisticsReport_BasicStatisticsReportItem.GenerateBasicStatisticsReport_BasicStatisticsReportSubItem();
					basicStatisticsReportSubItem.BasicStatisticsReportSubItemName = context.StringValue("GenerateBasicStatisticsReport.BasicStatisticsReport.Items["+ i +"].SubItems["+ j +"].BasicStatisticsReportSubItemName");
					basicStatisticsReportSubItem._Value = context.StringValue("GenerateBasicStatisticsReport.BasicStatisticsReport.Items["+ i +"].SubItems["+ j +"].Value");
					basicStatisticsReportSubItem.Count = context.IntegerValue("GenerateBasicStatisticsReport.BasicStatisticsReport.Items["+ i +"].SubItems["+ j +"].Count");
					basicStatisticsReportSubItem.Percentage = context.IntegerValue("GenerateBasicStatisticsReport.BasicStatisticsReport.Items["+ i +"].SubItems["+ j +"].Percentage");

					List<GenerateBasicStatisticsReportResponse.GenerateBasicStatisticsReport_BasicStatisticsReport.GenerateBasicStatisticsReport_BasicStatisticsReportItem.GenerateBasicStatisticsReport_BasicStatisticsReportSubItem.GenerateBasicStatisticsReport_KeyValuePair> basicStatisticsReportSubItem_details = new List<GenerateBasicStatisticsReportResponse.GenerateBasicStatisticsReport_BasicStatisticsReport.GenerateBasicStatisticsReport_BasicStatisticsReportItem.GenerateBasicStatisticsReport_BasicStatisticsReportSubItem.GenerateBasicStatisticsReport_KeyValuePair>();
					for (int k = 0; k < context.Length("GenerateBasicStatisticsReport.BasicStatisticsReport.Items["+ i +"].SubItems["+ j +"].Details.Length"); k++) {
						GenerateBasicStatisticsReportResponse.GenerateBasicStatisticsReport_BasicStatisticsReport.GenerateBasicStatisticsReport_BasicStatisticsReportItem.GenerateBasicStatisticsReport_BasicStatisticsReportSubItem.GenerateBasicStatisticsReport_KeyValuePair keyValuePair = new GenerateBasicStatisticsReportResponse.GenerateBasicStatisticsReport_BasicStatisticsReport.GenerateBasicStatisticsReport_BasicStatisticsReportItem.GenerateBasicStatisticsReport_BasicStatisticsReportSubItem.GenerateBasicStatisticsReport_KeyValuePair();
						keyValuePair.Key = context.StringValue("GenerateBasicStatisticsReport.BasicStatisticsReport.Items["+ i +"].SubItems["+ j +"].Details["+ k +"].Key");
						keyValuePair._Value = context.StringValue("GenerateBasicStatisticsReport.BasicStatisticsReport.Items["+ i +"].SubItems["+ j +"].Details["+ k +"].Value");

						basicStatisticsReportSubItem_details.Add(keyValuePair);
					}
					basicStatisticsReportSubItem.Details = basicStatisticsReportSubItem_details;

					basicStatisticsReportItem_subItems.Add(basicStatisticsReportSubItem);
				}
				basicStatisticsReportItem.SubItems = basicStatisticsReportItem_subItems;

				basicStatisticsReport_items.Add(basicStatisticsReportItem);
			}
			basicStatisticsReport.Items = basicStatisticsReport_items;
			generateBasicStatisticsReportResponse.BasicStatisticsReport = basicStatisticsReport;
        
			return generateBasicStatisticsReportResponse;
        }
    }
}
