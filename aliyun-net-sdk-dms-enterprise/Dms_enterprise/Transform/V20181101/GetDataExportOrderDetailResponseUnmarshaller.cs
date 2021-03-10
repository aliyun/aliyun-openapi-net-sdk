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
    public class GetDataExportOrderDetailResponseUnmarshaller
    {
        public static GetDataExportOrderDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDataExportOrderDetailResponse getDataExportOrderDetailResponse = new GetDataExportOrderDetailResponse();

			getDataExportOrderDetailResponse.HttpResponse = _ctx.HttpResponse;
			getDataExportOrderDetailResponse.RequestId = _ctx.StringValue("GetDataExportOrderDetail.RequestId");
			getDataExportOrderDetailResponse.ErrorCode = _ctx.StringValue("GetDataExportOrderDetail.ErrorCode");
			getDataExportOrderDetailResponse.ErrorMessage = _ctx.StringValue("GetDataExportOrderDetail.ErrorMessage");
			getDataExportOrderDetailResponse.Success = _ctx.BooleanValue("GetDataExportOrderDetail.Success");

			GetDataExportOrderDetailResponse.GetDataExportOrderDetail_DataExportOrderDetail dataExportOrderDetail = new GetDataExportOrderDetailResponse.GetDataExportOrderDetail_DataExportOrderDetail();

			GetDataExportOrderDetailResponse.GetDataExportOrderDetail_DataExportOrderDetail.GetDataExportOrderDetail_OrderDetail orderDetail = new GetDataExportOrderDetailResponse.GetDataExportOrderDetail_DataExportOrderDetail.GetDataExportOrderDetail_OrderDetail();
			orderDetail.IgnoreAffectRows = _ctx.BooleanValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.IgnoreAffectRows");
			orderDetail.ExeSQL = _ctx.StringValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.ExeSQL");
			orderDetail.Classify = _ctx.StringValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.Classify");
			orderDetail.IgnoreAffectRowsReason = _ctx.StringValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.IgnoreAffectRowsReason");
			orderDetail.Database = _ctx.StringValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.Database");
			orderDetail.DbId = _ctx.IntegerValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.DbId");
			orderDetail.ActualAffectRows = _ctx.LongValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.ActualAffectRows");
			orderDetail.Logic = _ctx.BooleanValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.Logic");
			orderDetail.EnvType = _ctx.StringValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.EnvType");
			dataExportOrderDetail.OrderDetail = orderDetail;

			GetDataExportOrderDetailResponse.GetDataExportOrderDetail_DataExportOrderDetail.GetDataExportOrderDetail_KeyInfo keyInfo = new GetDataExportOrderDetailResponse.GetDataExportOrderDetail_DataExportOrderDetail.GetDataExportOrderDetail_KeyInfo();
			keyInfo.JobStatus = _ctx.StringValue("GetDataExportOrderDetail.DataExportOrderDetail.KeyInfo.JobStatus");
			keyInfo.PreCheckId = _ctx.LongValue("GetDataExportOrderDetail.DataExportOrderDetail.KeyInfo.PreCheckId");
			dataExportOrderDetail.KeyInfo = keyInfo;
			getDataExportOrderDetailResponse.DataExportOrderDetail = dataExportOrderDetail;
        
			return getDataExportOrderDetailResponse;
        }
    }
}
