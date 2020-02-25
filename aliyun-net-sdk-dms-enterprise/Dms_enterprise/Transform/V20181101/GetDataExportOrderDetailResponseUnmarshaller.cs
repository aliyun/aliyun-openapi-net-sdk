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
        public static GetDataExportOrderDetailResponse Unmarshall(UnmarshallerContext context)
        {
			GetDataExportOrderDetailResponse getDataExportOrderDetailResponse = new GetDataExportOrderDetailResponse();

			getDataExportOrderDetailResponse.HttpResponse = context.HttpResponse;
			getDataExportOrderDetailResponse.RequestId = context.StringValue("GetDataExportOrderDetail.RequestId");
			getDataExportOrderDetailResponse.Success = context.BooleanValue("GetDataExportOrderDetail.Success");
			getDataExportOrderDetailResponse.ErrorMessage = context.StringValue("GetDataExportOrderDetail.ErrorMessage");
			getDataExportOrderDetailResponse.ErrorCode = context.StringValue("GetDataExportOrderDetail.ErrorCode");

			GetDataExportOrderDetailResponse.GetDataExportOrderDetail_DataExportOrderDetail dataExportOrderDetail = new GetDataExportOrderDetailResponse.GetDataExportOrderDetail_DataExportOrderDetail();

			GetDataExportOrderDetailResponse.GetDataExportOrderDetail_DataExportOrderDetail.GetDataExportOrderDetail_OrderDetail orderDetail = new GetDataExportOrderDetailResponse.GetDataExportOrderDetail_DataExportOrderDetail.GetDataExportOrderDetail_OrderDetail();
			orderDetail.ActualAffectRows = context.LongValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.ActualAffectRows");
			orderDetail.Classify = context.StringValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.Classify");
			orderDetail.Database = context.StringValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.Database");
			orderDetail.DbId = context.IntegerValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.DbId");
			orderDetail.EnvType = context.StringValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.EnvType");
			orderDetail.ExeSQL = context.StringValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.ExeSQL");
			orderDetail.IgnoreAffectRows = context.BooleanValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.IgnoreAffectRows");
			orderDetail.IgnoreAffectRowsReason = context.StringValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.IgnoreAffectRowsReason");
			orderDetail.Logic = context.BooleanValue("GetDataExportOrderDetail.DataExportOrderDetail.OrderDetail.Logic");
			dataExportOrderDetail.OrderDetail = orderDetail;

			GetDataExportOrderDetailResponse.GetDataExportOrderDetail_DataExportOrderDetail.GetDataExportOrderDetail_KeyInfo keyInfo = new GetDataExportOrderDetailResponse.GetDataExportOrderDetail_DataExportOrderDetail.GetDataExportOrderDetail_KeyInfo();
			keyInfo.JobStatus = context.StringValue("GetDataExportOrderDetail.DataExportOrderDetail.KeyInfo.JobStatus");
			keyInfo.PreCheckId = context.LongValue("GetDataExportOrderDetail.DataExportOrderDetail.KeyInfo.PreCheckId");
			dataExportOrderDetail.KeyInfo = keyInfo;
			getDataExportOrderDetailResponse.DataExportOrderDetail = dataExportOrderDetail;
        
			return getDataExportOrderDetailResponse;
        }
    }
}
