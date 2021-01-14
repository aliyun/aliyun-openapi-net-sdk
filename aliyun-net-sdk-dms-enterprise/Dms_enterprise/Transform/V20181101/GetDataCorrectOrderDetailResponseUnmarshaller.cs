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
        public static GetDataCorrectOrderDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDataCorrectOrderDetailResponse getDataCorrectOrderDetailResponse = new GetDataCorrectOrderDetailResponse();

			getDataCorrectOrderDetailResponse.HttpResponse = _ctx.HttpResponse;
			getDataCorrectOrderDetailResponse.RequestId = _ctx.StringValue("GetDataCorrectOrderDetail.RequestId");
			getDataCorrectOrderDetailResponse.Success = _ctx.BooleanValue("GetDataCorrectOrderDetail.Success");
			getDataCorrectOrderDetailResponse.ErrorMessage = _ctx.StringValue("GetDataCorrectOrderDetail.ErrorMessage");
			getDataCorrectOrderDetailResponse.ErrorCode = _ctx.StringValue("GetDataCorrectOrderDetail.ErrorCode");

			GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail dataCorrectOrderDetail = new GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail();

			GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_OrderDetail orderDetail = new GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_OrderDetail();
			orderDetail.Classify = _ctx.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.Classify");
			orderDetail.EstimateAffectRows = _ctx.LongValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.EstimateAffectRows");
			orderDetail.ActualAffectRows = _ctx.LongValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.ActualAffectRows");
			orderDetail.IgnoreAffectRows = _ctx.BooleanValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.IgnoreAffectRows");
			orderDetail.IgnoreAffectRowsReason = _ctx.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.IgnoreAffectRowsReason");
			orderDetail.SqlType = _ctx.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.SqlType");
			orderDetail.ExeSQL = _ctx.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.ExeSQL");
			orderDetail.AttachmentName = _ctx.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.AttachmentName");
			orderDetail.RbSQLType = _ctx.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.RbSQLType");
			orderDetail.RbSQL = _ctx.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.RbSQL");
			orderDetail.RbAttachmentName = _ctx.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.OrderDetail.RbAttachmentName");
			dataCorrectOrderDetail.OrderDetail = orderDetail;

			List<GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_TaskCheckDO> dataCorrectOrderDetail_preCheckDetail = new List<GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_TaskCheckDO>();
			for (int i = 0; i < _ctx.Length("GetDataCorrectOrderDetail.DataCorrectOrderDetail.PreCheckDetail.Length"); i++) {
				GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_TaskCheckDO taskCheckDO = new GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_TaskCheckDO();
				taskCheckDO.CheckStatus = _ctx.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.PreCheckDetail["+ i +"].CheckStatus");
				taskCheckDO.CheckStep = _ctx.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.PreCheckDetail["+ i +"].CheckStep");
				taskCheckDO.UserTip = _ctx.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.PreCheckDetail["+ i +"].UserTip");

				dataCorrectOrderDetail_preCheckDetail.Add(taskCheckDO);
			}
			dataCorrectOrderDetail.PreCheckDetail = dataCorrectOrderDetail_preCheckDetail;

			List<GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_Database> dataCorrectOrderDetail_databaseList = new List<GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_Database>();
			for (int i = 0; i < _ctx.Length("GetDataCorrectOrderDetail.DataCorrectOrderDetail.DatabaseList.Length"); i++) {
				GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_Database database = new GetDataCorrectOrderDetailResponse.GetDataCorrectOrderDetail_DataCorrectOrderDetail.GetDataCorrectOrderDetail_Database();
				database.SearchName = _ctx.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.DatabaseList["+ i +"].SearchName");
				database.EnvType = _ctx.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.DatabaseList["+ i +"].EnvType");
				database.DbType = _ctx.StringValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.DatabaseList["+ i +"].DbType");
				database.DbId = _ctx.IntegerValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.DatabaseList["+ i +"].DbId");
				database.Logic = _ctx.BooleanValue("GetDataCorrectOrderDetail.DataCorrectOrderDetail.DatabaseList["+ i +"].Logic");

				dataCorrectOrderDetail_databaseList.Add(database);
			}
			dataCorrectOrderDetail.DatabaseList = dataCorrectOrderDetail_databaseList;
			getDataCorrectOrderDetailResponse.DataCorrectOrderDetail = dataCorrectOrderDetail;
        
			return getDataCorrectOrderDetailResponse;
        }
    }
}
