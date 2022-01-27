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
        public static ListSensitiveColumnsDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSensitiveColumnsDetailResponse listSensitiveColumnsDetailResponse = new ListSensitiveColumnsDetailResponse();

			listSensitiveColumnsDetailResponse.HttpResponse = _ctx.HttpResponse;
			listSensitiveColumnsDetailResponse.RequestId = _ctx.StringValue("ListSensitiveColumnsDetail.RequestId");
			listSensitiveColumnsDetailResponse.ErrorCode = _ctx.StringValue("ListSensitiveColumnsDetail.ErrorCode");
			listSensitiveColumnsDetailResponse.ErrorMessage = _ctx.StringValue("ListSensitiveColumnsDetail.ErrorMessage");
			listSensitiveColumnsDetailResponse.Success = _ctx.BooleanValue("ListSensitiveColumnsDetail.Success");

			List<ListSensitiveColumnsDetailResponse.ListSensitiveColumnsDetail_SensitiveColumnsDetail> listSensitiveColumnsDetailResponse_sensitiveColumnsDetailList = new List<ListSensitiveColumnsDetailResponse.ListSensitiveColumnsDetail_SensitiveColumnsDetail>();
			for (int i = 0; i < _ctx.Length("ListSensitiveColumnsDetail.SensitiveColumnsDetailList.Length"); i++) {
				ListSensitiveColumnsDetailResponse.ListSensitiveColumnsDetail_SensitiveColumnsDetail sensitiveColumnsDetail = new ListSensitiveColumnsDetailResponse.ListSensitiveColumnsDetail_SensitiveColumnsDetail();
				sensitiveColumnsDetail.DbId = _ctx.LongValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].DbId");
				sensitiveColumnsDetail.ColumnName = _ctx.StringValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].ColumnName");
				sensitiveColumnsDetail.ColumnDescription = _ctx.StringValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].ColumnDescription");
				sensitiveColumnsDetail.TableName = _ctx.StringValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].TableName");
				sensitiveColumnsDetail.DbType = _ctx.StringValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].DbType");
				sensitiveColumnsDetail.ColumnType = _ctx.StringValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].ColumnType");
				sensitiveColumnsDetail.Logic = _ctx.BooleanValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].Logic");
				sensitiveColumnsDetail.SchemaName = _ctx.StringValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].SchemaName");
				sensitiveColumnsDetail.SearchName = _ctx.StringValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].SearchName");
				sensitiveColumnsDetail.EnvType = _ctx.StringValue("ListSensitiveColumnsDetail.SensitiveColumnsDetailList["+ i +"].EnvType");

				listSensitiveColumnsDetailResponse_sensitiveColumnsDetailList.Add(sensitiveColumnsDetail);
			}
			listSensitiveColumnsDetailResponse.SensitiveColumnsDetailList = listSensitiveColumnsDetailResponse_sensitiveColumnsDetailList;
        
			return listSensitiveColumnsDetailResponse;
        }
    }
}
