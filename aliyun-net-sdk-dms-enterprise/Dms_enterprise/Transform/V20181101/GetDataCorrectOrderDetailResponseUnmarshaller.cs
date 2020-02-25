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
    public class GetDataCorrectOrderDetailResponseUnmarshaller
    {
        public static GetDataCorrectOrderDetailResponse Unmarshall(UnmarshallerContext context)
        {
			GetDataCorrectOrderDetailResponse getDataCorrectOrderDetailResponse = new GetDataCorrectOrderDetailResponse();

			getDataCorrectOrderDetailResponse.HttpResponse = context.HttpResponse;
			getDataCorrectOrderDetailResponse.RequestId = context.StringValue("GetDataCorrectOrderDetail.RequestId");
			getDataCorrectOrderDetailResponse.Success = context.BooleanValue("GetDataCorrectOrderDetail.Success");
			getDataCorrectOrderDetailResponse.ErrorMessage = context.StringValue("GetDataCorrectOrderDetail.ErrorMessage");
			getDataCorrectOrderDetailResponse.ErrorCode = context.StringValue("GetDataCorrectOrderDetail.ErrorCode");

			GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail dataCorrectOrderDetail = new GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail();

			GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_OrderDetail orderDetail = new GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_OrderDetail();
			orderDetail.Classify = context.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.Classify");
			orderDetail.EstimateAffectRows = context.LongValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.EstimateAffectRows");
			orderDetail.ActualAffectRows = context.LongValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.ActualAffectRows");
			orderDetail.IgnoreAffectRows = context.BooleanValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.IgnoreAffectRows");
			orderDetail.IgnoreAffectRowsReason = context.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.IgnoreAffectRowsReason");
			orderDetail.SqlType = context.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.SqlType");
			orderDetail.ExeSQL = context.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.ExeSQL");
			orderDetail.AttachmentName = context.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.AttachmentName");
			orderDetail.RbSQLType = context.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.RbSQLType");
			orderDetail.RbSQL = context.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.RbSQL");
			orderDetail.RbAttachmentName = context.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.RbAttachmentName");
			dataCorrectOrderDetail.OrderDetail = orderDetail;

			List<GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_TaskCheckDO> dataCorrectOrderDetail_preCheckDetail = new List<GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_TaskCheckDO>();
			for (int i = 0; i < context.Length("GetDataCorrectOrderDetail.DataCorrectOrderDetail.PreCheckDetail.Length"); i++) {
				GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_TaskCheckDO taskCheckDO = new GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_TaskCheckDO();
				taskCheckDO.CheckStatus = context.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.PreCheckDetail["+ i +"].CheckStatus");
				taskCheckDO.CheckStep = context.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.PreCheckDetail["+ i +"].CheckStep");
				taskCheckDO.UserTip = context.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.PreCheckDetail["+ i +"].UserTip");

				dataCorrectOrderDetail_preCheckDetail.Add(taskCheckDO);
			}
			dataCorrectOrderDetail.PreCheckDetail = dataCorrectOrderDetail_preCheckDetail;

			List<GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_Database> dataCorrectOrderDetail_databaseList = new List<GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_Database>();
			for (int i = 0; i < context.Length("GetDataCorrectOrderDetail.DataCorrectOrderDetail.DatabaseList.Length"); i++) {
				GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_Database database = new GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_Database();
				database.SearchName = context.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.DatabaseList["+ i +"].SearchName");
				database.EnvType = context.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.DatabaseList["+ i +"].EnvType");
				database.DbType = context.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.DatabaseList["+ i +"].DbType");
				database.DbId = context.IntegerValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.DatabaseList["+ i +"].DbId");
				database.Logic = context.BooleanValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.DatabaseList["+ i +"].Logic");

				dataCorrectOrderDetail_databaseList.Add(database);
			}
			dataCorrectOrderDetail.DatabaseList = dataCorrectOrderDetail_databaseList;
			getDataCorrectOrderDetailResponse.DataCorrectOrderDetail = dataCorrectOrderDetail;
        
			return getDataCorrectOrderDetailResponse;
        }
    }
}
