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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribeGroupProductionsResponseUnmarshaller
    {
        public static DescribeGroupProductionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGroupProductionsResponse describeGroupProductionsResponse = new DescribeGroupProductionsResponse();

			describeGroupProductionsResponse.HttpResponse = _ctx.HttpResponse;
			describeGroupProductionsResponse.RequestId = _ctx.StringValue("DescribeGroupProductions.RequestId");

			DescribeGroupProductionsResponse.DescribeGroupProductions_Page page = new DescribeGroupProductionsResponse.DescribeGroupProductions_Page();
			page.TotalCount = _ctx.IntegerValue("DescribeGroupProductions.Page.TotalCount");
			page.PageNumber = _ctx.IntegerValue("DescribeGroupProductions.Page.PageNumber");
			page.PageSize = _ctx.IntegerValue("DescribeGroupProductions.Page.PageSize");
			describeGroupProductionsResponse.Page = page;

			List<DescribeGroupProductionsResponse.DescribeGroupProductions_DataItem> describeGroupProductionsResponse_data = new List<DescribeGroupProductionsResponse.DescribeGroupProductions_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeGroupProductions.Data.Length"); i++) {
				DescribeGroupProductionsResponse.DescribeGroupProductions_DataItem dataItem = new DescribeGroupProductionsResponse.DescribeGroupProductions_DataItem();
				dataItem.GroupName = _ctx.StringValue("DescribeGroupProductions.Data["+ i +"].GroupName");

				List<DescribeGroupProductionsResponse.DescribeGroupProductions_DataItem.DescribeGroupProductions_Production> dataItem_productions = new List<DescribeGroupProductionsResponse.DescribeGroupProductions_DataItem.DescribeGroupProductions_Production>();
				for (int j = 0; j < _ctx.Length("DescribeGroupProductions.Data["+ i +"].Productions.Length"); j++) {
					DescribeGroupProductionsResponse.DescribeGroupProductions_DataItem.DescribeGroupProductions_Production production = new DescribeGroupProductionsResponse.DescribeGroupProductions_DataItem.DescribeGroupProductions_Production();
					production.Code = _ctx.StringValue("DescribeGroupProductions.Data["+ i +"].Productions["+ j +"].Code");
					production.Name = _ctx.StringValue("DescribeGroupProductions.Data["+ i +"].Productions["+ j +"].Name");
					production.ShortName = _ctx.StringValue("DescribeGroupProductions.Data["+ i +"].Productions["+ j +"].ShortName");
					production.Description = _ctx.StringValue("DescribeGroupProductions.Data["+ i +"].Productions["+ j +"].Description");
					production.Group = _ctx.StringValue("DescribeGroupProductions.Data["+ i +"].Productions["+ j +"].Group");
					production.DefaultVersion = _ctx.StringValue("DescribeGroupProductions.Data["+ i +"].Productions["+ j +"].DefaultVersion");
					production.DefaultDomain = _ctx.StringValue("DescribeGroupProductions.Data["+ i +"].Productions["+ j +"].DefaultDomain");
					production.RamCode = _ctx.StringValue("DescribeGroupProductions.Data["+ i +"].Productions["+ j +"].RamCode");
					production.Source = _ctx.StringValue("DescribeGroupProductions.Data["+ i +"].Productions["+ j +"].Source");

					List<string> production_versions = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeGroupProductions.Data["+ i +"].Productions["+ j +"].Versions.Length"); k++) {
						production_versions.Add(_ctx.StringValue("DescribeGroupProductions.Data["+ i +"].Productions["+ j +"].Versions["+ k +"]"));
					}
					production.Versions = production_versions;

					List<string> production_fullDomains = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeGroupProductions.Data["+ i +"].Productions["+ j +"].FullDomains.Length"); k++) {
						production_fullDomains.Add(_ctx.StringValue("DescribeGroupProductions.Data["+ i +"].Productions["+ j +"].FullDomains["+ k +"]"));
					}
					production.FullDomains = production_fullDomains;

					List<DescribeGroupProductionsResponse.DescribeGroupProductions_DataItem.DescribeGroupProductions_Production.DescribeGroupProductions_PolicyListItem> production_policyList = new List<DescribeGroupProductionsResponse.DescribeGroupProductions_DataItem.DescribeGroupProductions_Production.DescribeGroupProductions_PolicyListItem>();
					for (int k = 0; k < _ctx.Length("DescribeGroupProductions.Data["+ i +"].Productions["+ j +"].PolicyList.Length"); k++) {
						DescribeGroupProductionsResponse.DescribeGroupProductions_DataItem.DescribeGroupProductions_Production.DescribeGroupProductions_PolicyListItem policyListItem = new DescribeGroupProductionsResponse.DescribeGroupProductions_DataItem.DescribeGroupProductions_Production.DescribeGroupProductions_PolicyListItem();
						policyListItem.PolicyName = _ctx.StringValue("DescribeGroupProductions.Data["+ i +"].Productions["+ j +"].PolicyList["+ k +"].PolicyName");
						policyListItem.Type = _ctx.StringValue("DescribeGroupProductions.Data["+ i +"].Productions["+ j +"].PolicyList["+ k +"].Type");

						production_policyList.Add(policyListItem);
					}
					production.PolicyList = production_policyList;

					dataItem_productions.Add(production);
				}
				dataItem.Productions = dataItem_productions;

				describeGroupProductionsResponse_data.Add(dataItem);
			}
			describeGroupProductionsResponse.Data = describeGroupProductionsResponse_data;
        
			return describeGroupProductionsResponse;
        }
    }
}
