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
    public class ListHiveColumnLineagesResponseUnmarshaller
    {
        public static ListHiveColumnLineagesResponse Unmarshall(UnmarshallerContext context)
        {
			ListHiveColumnLineagesResponse listHiveColumnLineagesResponse = new ListHiveColumnLineagesResponse();

			listHiveColumnLineagesResponse.HttpResponse = context.HttpResponse;
			listHiveColumnLineagesResponse.ErrorCode = context.StringValue("ListHiveColumnLineages.ErrorCode");
			listHiveColumnLineagesResponse.ErrorMessage = context.StringValue("ListHiveColumnLineages.ErrorMessage");
			listHiveColumnLineagesResponse.RequestId = context.StringValue("ListHiveColumnLineages.RequestId");

			ListHiveColumnLineagesResponse.ListHiveColumnLineages_Data data = new ListHiveColumnLineagesResponse.ListHiveColumnLineages_Data();
			data.UpstreamNumber = context.IntegerValue("ListHiveColumnLineages.Data.UpstreamNumber");
			data.DownstreamNumber = context.IntegerValue("ListHiveColumnLineages.Data.DownstreamNumber");

			List<ListHiveColumnLineagesResponse.ListHiveColumnLineages_Data.ListHiveColumnLineages_ColumnLineage> data_upstreamLineages = new List<ListHiveColumnLineagesResponse.ListHiveColumnLineages_Data.ListHiveColumnLineages_ColumnLineage>();
			for (int i = 0; i < context.Length("ListHiveColumnLineages.Data.UpstreamLineages.Length"); i++) {
				ListHiveColumnLineagesResponse.ListHiveColumnLineages_Data.ListHiveColumnLineages_ColumnLineage columnLineage = new ListHiveColumnLineagesResponse.ListHiveColumnLineages_Data.ListHiveColumnLineages_ColumnLineage();
				columnLineage.ModifiedTime = context.StringValue("ListHiveColumnLineages.Data.UpstreamLineages["+ i +"].ModifiedTime");
				columnLineage.DirectDownColumnNumber = context.IntegerValue("ListHiveColumnLineages.Data.UpstreamLineages["+ i +"].DirectDownColumnNumber");
				columnLineage.DatabaseName = context.StringValue("ListHiveColumnLineages.Data.UpstreamLineages["+ i +"].DatabaseName");
				columnLineage.ClusterId = context.StringValue("ListHiveColumnLineages.Data.UpstreamLineages["+ i +"].ClusterId");
				columnLineage.Source = context.StringValue("ListHiveColumnLineages.Data.UpstreamLineages["+ i +"].Source");
				columnLineage.TableName = context.StringValue("ListHiveColumnLineages.Data.UpstreamLineages["+ i +"].TableName");
				columnLineage.DirectDownTableNumber = context.IntegerValue("ListHiveColumnLineages.Data.UpstreamLineages["+ i +"].DirectDownTableNumber");
				columnLineage.DirectUpperTableNumber = context.IntegerValue("ListHiveColumnLineages.Data.UpstreamLineages["+ i +"].DirectUpperTableNumber");
				columnLineage.CreateTime = context.StringValue("ListHiveColumnLineages.Data.UpstreamLineages["+ i +"].CreateTime");
				columnLineage.DirectUpperColumnNumber = context.IntegerValue("ListHiveColumnLineages.Data.UpstreamLineages["+ i +"].DirectUpperColumnNumber");
				columnLineage.ColumnName = context.StringValue("ListHiveColumnLineages.Data.UpstreamLineages["+ i +"].ColumnName");

				data_upstreamLineages.Add(columnLineage);
			}
			data.UpstreamLineages = data_upstreamLineages;

			List<ListHiveColumnLineagesResponse.ListHiveColumnLineages_Data.ListHiveColumnLineages_ColumnLineage> data_downstreamLineages = new List<ListHiveColumnLineagesResponse.ListHiveColumnLineages_Data.ListHiveColumnLineages_ColumnLineage>();
			for (int i = 0; i < context.Length("ListHiveColumnLineages.Data.DownstreamLineages.Length"); i++) {
				ListHiveColumnLineagesResponse.ListHiveColumnLineages_Data.ListHiveColumnLineages_ColumnLineage columnLineage = new ListHiveColumnLineagesResponse.ListHiveColumnLineages_Data.ListHiveColumnLineages_ColumnLineage();
				columnLineage.ModifiedTime = context.StringValue("ListHiveColumnLineages.Data.DownstreamLineages["+ i +"].ModifiedTime");
				columnLineage.DirectDownColumnNumber = context.IntegerValue("ListHiveColumnLineages.Data.DownstreamLineages["+ i +"].DirectDownColumnNumber");
				columnLineage.DatabaseName = context.StringValue("ListHiveColumnLineages.Data.DownstreamLineages["+ i +"].DatabaseName");
				columnLineage.ClusterId = context.StringValue("ListHiveColumnLineages.Data.DownstreamLineages["+ i +"].ClusterId");
				columnLineage.Source = context.StringValue("ListHiveColumnLineages.Data.DownstreamLineages["+ i +"].Source");
				columnLineage.TableName = context.StringValue("ListHiveColumnLineages.Data.DownstreamLineages["+ i +"].TableName");
				columnLineage.DirectDownTableNumber = context.IntegerValue("ListHiveColumnLineages.Data.DownstreamLineages["+ i +"].DirectDownTableNumber");
				columnLineage.DirectUpperTableNumber = context.IntegerValue("ListHiveColumnLineages.Data.DownstreamLineages["+ i +"].DirectUpperTableNumber");
				columnLineage.CreateTime = context.StringValue("ListHiveColumnLineages.Data.DownstreamLineages["+ i +"].CreateTime");
				columnLineage.DirectUpperColumnNumber = context.IntegerValue("ListHiveColumnLineages.Data.DownstreamLineages["+ i +"].DirectUpperColumnNumber");
				columnLineage.ColumnName = context.StringValue("ListHiveColumnLineages.Data.DownstreamLineages["+ i +"].ColumnName");

				data_downstreamLineages.Add(columnLineage);
			}
			data.DownstreamLineages = data_downstreamLineages;
			listHiveColumnLineagesResponse.Data = data;
        
			return listHiveColumnLineagesResponse;
        }
    }
}
