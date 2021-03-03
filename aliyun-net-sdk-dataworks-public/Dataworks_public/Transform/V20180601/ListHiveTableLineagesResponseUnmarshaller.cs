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
using Aliyun.Acs.dataworks_public.Model.V20180601;

namespace Aliyun.Acs.dataworks_public.Transform.V20180601
{
    public class ListHiveTableLineagesResponseUnmarshaller
    {
        public static ListHiveTableLineagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListHiveTableLineagesResponse listHiveTableLineagesResponse = new ListHiveTableLineagesResponse();

			listHiveTableLineagesResponse.HttpResponse = _ctx.HttpResponse;
			listHiveTableLineagesResponse.ErrorCode = _ctx.StringValue("ListHiveTableLineages.ErrorCode");
			listHiveTableLineagesResponse.ErrorMessage = _ctx.StringValue("ListHiveTableLineages.ErrorMessage");
			listHiveTableLineagesResponse.RequestId = _ctx.StringValue("ListHiveTableLineages.RequestId");

			ListHiveTableLineagesResponse.ListHiveTableLineages_Data data = new ListHiveTableLineagesResponse.ListHiveTableLineages_Data();
			data.UpstreamNumber = _ctx.IntegerValue("ListHiveTableLineages.Data.UpstreamNumber");
			data.DownstreamNumber = _ctx.IntegerValue("ListHiveTableLineages.Data.DownstreamNumber");

			List<ListHiveTableLineagesResponse.ListHiveTableLineages_Data.ListHiveTableLineages_TableLineage> data_upstreamLineages = new List<ListHiveTableLineagesResponse.ListHiveTableLineages_Data.ListHiveTableLineages_TableLineage>();
			for (int i = 0; i < _ctx.Length("ListHiveTableLineages.Data.UpstreamLineages.Length"); i++) {
				ListHiveTableLineagesResponse.ListHiveTableLineages_Data.ListHiveTableLineages_TableLineage tableLineage = new ListHiveTableLineagesResponse.ListHiveTableLineages_Data.ListHiveTableLineages_TableLineage();
				tableLineage.ModifiedTime = _ctx.StringValue("ListHiveTableLineages.Data.UpstreamLineages["+ i +"].ModifiedTime");
				tableLineage.DatabaseName = _ctx.StringValue("ListHiveTableLineages.Data.UpstreamLineages["+ i +"].DatabaseName");
				tableLineage.Engine = _ctx.StringValue("ListHiveTableLineages.Data.UpstreamLineages["+ i +"].Engine");
				tableLineage.CreateTime = _ctx.StringValue("ListHiveTableLineages.Data.UpstreamLineages["+ i +"].CreateTime");
				tableLineage.ClusterId = _ctx.StringValue("ListHiveTableLineages.Data.UpstreamLineages["+ i +"].ClusterId");
				tableLineage.Source = _ctx.StringValue("ListHiveTableLineages.Data.UpstreamLineages["+ i +"].Source");
				tableLineage.TableName = _ctx.StringValue("ListHiveTableLineages.Data.UpstreamLineages["+ i +"].TableName");
				tableLineage.JobId = _ctx.StringValue("ListHiveTableLineages.Data.UpstreamLineages["+ i +"].JobId");
				tableLineage.QueryText = _ctx.StringValue("ListHiveTableLineages.Data.UpstreamLineages["+ i +"].QueryText");

				data_upstreamLineages.Add(tableLineage);
			}
			data.UpstreamLineages = data_upstreamLineages;

			List<ListHiveTableLineagesResponse.ListHiveTableLineages_Data.ListHiveTableLineages_TableLineage> data_downstreamLineages = new List<ListHiveTableLineagesResponse.ListHiveTableLineages_Data.ListHiveTableLineages_TableLineage>();
			for (int i = 0; i < _ctx.Length("ListHiveTableLineages.Data.DownstreamLineages.Length"); i++) {
				ListHiveTableLineagesResponse.ListHiveTableLineages_Data.ListHiveTableLineages_TableLineage tableLineage = new ListHiveTableLineagesResponse.ListHiveTableLineages_Data.ListHiveTableLineages_TableLineage();
				tableLineage.ModifiedTime = _ctx.StringValue("ListHiveTableLineages.Data.DownstreamLineages["+ i +"].ModifiedTime");
				tableLineage.DatabaseName = _ctx.StringValue("ListHiveTableLineages.Data.DownstreamLineages["+ i +"].DatabaseName");
				tableLineage.Engine = _ctx.StringValue("ListHiveTableLineages.Data.DownstreamLineages["+ i +"].Engine");
				tableLineage.CreateTime = _ctx.StringValue("ListHiveTableLineages.Data.DownstreamLineages["+ i +"].CreateTime");
				tableLineage.ClusterId = _ctx.StringValue("ListHiveTableLineages.Data.DownstreamLineages["+ i +"].ClusterId");
				tableLineage.Source = _ctx.StringValue("ListHiveTableLineages.Data.DownstreamLineages["+ i +"].Source");
				tableLineage.TableName = _ctx.StringValue("ListHiveTableLineages.Data.DownstreamLineages["+ i +"].TableName");
				tableLineage.JobId = _ctx.StringValue("ListHiveTableLineages.Data.DownstreamLineages["+ i +"].JobId");
				tableLineage.QueryText = _ctx.StringValue("ListHiveTableLineages.Data.DownstreamLineages["+ i +"].QueryText");

				data_downstreamLineages.Add(tableLineage);
			}
			data.DownstreamLineages = data_downstreamLineages;
			listHiveTableLineagesResponse.Data = data;
        
			return listHiveTableLineagesResponse;
        }
    }
}
