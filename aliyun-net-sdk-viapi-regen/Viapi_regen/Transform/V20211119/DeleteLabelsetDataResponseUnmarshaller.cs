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
using Aliyun.Acs.viapi_regen.Model.V20211119;

namespace Aliyun.Acs.viapi_regen.Transform.V20211119
{
    public class DeleteLabelsetDataResponseUnmarshaller
    {
        public static DeleteLabelsetDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteLabelsetDataResponse deleteLabelsetDataResponse = new DeleteLabelsetDataResponse();

			deleteLabelsetDataResponse.HttpResponse = _ctx.HttpResponse;
			deleteLabelsetDataResponse.Message = _ctx.StringValue("DeleteLabelsetData.Message");
			deleteLabelsetDataResponse.RequestId = _ctx.StringValue("DeleteLabelsetData.RequestId");
			deleteLabelsetDataResponse.Code = _ctx.StringValue("DeleteLabelsetData.Code");

			DeleteLabelsetDataResponse.DeleteLabelsetData_Data data = new DeleteLabelsetDataResponse.DeleteLabelsetData_Data();
			data.Id = _ctx.LongValue("DeleteLabelsetData.Data.Id");
			data.GmtCreate = _ctx.LongValue("DeleteLabelsetData.Data.GmtCreate");
			data.Name = _ctx.StringValue("DeleteLabelsetData.Data.Name");
			data.Description = _ctx.StringValue("DeleteLabelsetData.Data.Description");
			data.LabelType = _ctx.StringValue("DeleteLabelsetData.Data.LabelType");
			data.Status = _ctx.StringValue("DeleteLabelsetData.Data.Status");
			data.Total = _ctx.LongValue("DeleteLabelsetData.Data.Total");
			deleteLabelsetDataResponse.Data = data;
        
			return deleteLabelsetDataResponse;
        }
    }
}
