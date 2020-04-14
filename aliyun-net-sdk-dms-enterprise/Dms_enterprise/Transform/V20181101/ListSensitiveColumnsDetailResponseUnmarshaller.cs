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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class ListSensitiveColumnsDetailResponseUnmarshaller
    {
        public static ListSensitiveColumnsDetailResponse Unmarshall(UnmarshallerContext context)
        {
			ListSensitiveColumnsDetailResponse listSensitiveColumnsDetailResponse = new ListSensitiveColumnsDetailResponse();

			listSensitiveColumnsDetailResponse.HttpResponse = context.HttpResponse;
			listSensitiveColumnsDetailResponse.RequestId = context.StringValue("ListSensitiveColumnsDetail.RequestId");
			listSensitiveColumnsDetailResponse.Success = context.BooleanValue("ListSensitiveColumnsDetail.Success");
			listSensitiveColumnsDetailResponse.ErrorMessage = context.StringValue("ListSensitiveColumnsDetail.ErrorMessage");
			listSensitiveColumnsDetailResponse.ErrorCode = context.StringValue("ListSensitiveColumnsDetail.ErrorCode");

			List<ListSensitiveColumnsDetailResponse.ListSensitiveColumnsDetail_SensitiveColumnsDetail> listSensitiveColumnsDetailResponse_sensitiveColumnsDetailList = new List<ListSensitiveColumnsDetailResponse.ListSensitiveColumnsDetail_SensitiveColumnsDetail>();
			for (int i = 0; i < context.Length("ListSensitiveColumnsDetail.SensitiveColumnsDetailList.Length"); i++) {
				ListSensitiveColumnsDetailResponse.ListSensitiveColumnsDetail_SensitiveColumnsDetail sensitiveColumnsDetail = new ListSensitiveColumnsDetailResponse.ListSensitiveColumnsDetail_SensitiveColumnsDetail();
				sensitiveColumnsDetail.SchemaName = context.StringValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].SchemaName");
				sensitiveColumnsDetail.TableName = context.StringValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].TableName");
				sensitiveColumnsDetail.ColumnName = context.StringValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].ColumnName");
				sensitiveColumnsDetail.SearchName = context.StringValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].SearchName");
				sensitiveColumnsDetail.DbId = context.LongValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].DbId");
				sensitiveColumnsDetail.EnvType = context.StringValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].EnvType");
				sensitiveColumnsDetail.DbType = context.StringValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].DbType");
				sensitiveColumnsDetail.Logic = context.BooleanValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].Logic");
				sensitiveColumnsDetail.ColumnType = context.StringValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].ColumnType");
				sensitiveColumnsDetail.ColumnDescription = context.StringValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].ColumnDescription");

				listSensitiveColumnsDetailResponse_sensitiveColumnsDetailList.Add(sensitiveColumnsDetail);
			}
			listSensitiveColumnsDetailResponse.SensitiveColumnsDetailList = listSensitiveColumnsDetailResponse_sensitiveColumnsDetailList;
        
			return listSensitiveColumnsDetailResponse;
        }
    }
}
