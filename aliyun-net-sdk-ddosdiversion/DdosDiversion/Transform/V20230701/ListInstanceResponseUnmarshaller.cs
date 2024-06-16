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
using Aliyun.Acs.DdosDiversion.Model.V20230701;

namespace Aliyun.Acs.DdosDiversion.Transform.V20230701
{
    public class ListInstanceResponseUnmarshaller
    {
        public static ListInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstanceResponse listInstanceResponse = new ListInstanceResponse();

			listInstanceResponse.HttpResponse = _ctx.HttpResponse;
			listInstanceResponse.Code = _ctx.LongValue("ListInstance.Code");
			listInstanceResponse.RequestId = _ctx.StringValue("ListInstance.RequestId");
			listInstanceResponse.Message = _ctx.StringValue("ListInstance.Message");

			List<ListInstanceResponse.ListInstance_DataItem> listInstanceResponse_data = new List<ListInstanceResponse.ListInstance_DataItem>();
			for (int i = 0; i < _ctx.Length("ListInstance.Data.Length"); i++) {
				ListInstanceResponse.ListInstance_DataItem dataItem = new ListInstanceResponse.ListInstance_DataItem();
				dataItem.Total = _ctx.LongValue("ListInstance.Data["+ i +"].Total");
				dataItem.Page = _ctx.LongValue("ListInstance.Data["+ i +"].Page");
				dataItem.Num = _ctx.LongValue("ListInstance.Data["+ i +"].Num");

				List<ListInstanceResponse.ListInstance_DataItem.ListInstance_Data> dataItem_instances = new List<ListInstanceResponse.ListInstance_DataItem.ListInstance_Data>();
				for (int j = 0; j < _ctx.Length("ListInstance.Data["+ i +"].Instances.Length"); j++) {
					ListInstanceResponse.ListInstance_DataItem.ListInstance_Data data = new ListInstanceResponse.ListInstance_DataItem.ListInstance_Data();
					data.UserId = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].UserId");
					data.SaleId = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].SaleId");
					data.InstanceId = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].InstanceId");
					data.Name = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].Name");
					data.Status = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].Status");
					data.Comment = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].Comment");
					data.Message = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].Message");
					data.GmtExpire = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].GmtExpire");
					data.GmtCreate = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].GmtCreate");
					data.GmtModify = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].GmtModify");

					ListInstanceResponse.ListInstance_DataItem.ListInstance_Data.ListInstance_Spec spec = new ListInstanceResponse.ListInstance_DataItem.ListInstance_Data.ListInstance_Spec();
					spec.IdcNumbers = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].Spec.IdcNumbers");
					spec.NormalBandwidth = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].Spec.NormalBandwidth");
					spec.IpSubnetNums = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].Spec.IpSubnetNums");
					spec.Coverage = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].Spec.Coverage");
					spec.Edition = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].Spec.Edition");
					spec.MitigationCapacity = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].Spec.MitigationCapacity");
					spec.MitigationNums = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].Spec.MitigationNums");
					spec.DiversionType = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].Spec.DiversionType");
					spec.MitigationAnalysis = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].Spec.MitigationAnalysis");
					spec.MitigationAnalysisCapacity = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].Spec.MitigationAnalysisCapacity");
					spec.InitialInstallation = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].Spec.InitialInstallation");
					spec.InitialQty = _ctx.StringValue("ListInstance.Data["+ i +"].Instances["+ j +"].Spec.InitialQty");
					data.Spec = spec;

					dataItem_instances.Add(data);
				}
				dataItem.Instances = dataItem_instances;

				listInstanceResponse_data.Add(dataItem);
			}
			listInstanceResponse.Data = listInstanceResponse_data;
        
			return listInstanceResponse;
        }
    }
}
