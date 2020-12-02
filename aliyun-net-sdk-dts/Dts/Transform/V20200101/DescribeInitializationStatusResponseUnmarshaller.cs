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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class DescribeInitializationStatusResponseUnmarshaller
    {
        public static DescribeInitializationStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInitializationStatusResponse describeInitializationStatusResponse = new DescribeInitializationStatusResponse();

			describeInitializationStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeInitializationStatusResponse.ErrCode = _ctx.StringValue("DescribeInitializationStatus.ErrCode");
			describeInitializationStatusResponse.ErrMessage = _ctx.StringValue("DescribeInitializationStatus.ErrMessage");
			describeInitializationStatusResponse.RequestId = _ctx.StringValue("DescribeInitializationStatus.RequestId");
			describeInitializationStatusResponse.Success = _ctx.StringValue("DescribeInitializationStatus.Success");

			List<DescribeInitializationStatusResponse.DescribeInitializationStatus_DataInitializationDetail> describeInitializationStatusResponse_dataInitializationDetails = new List<DescribeInitializationStatusResponse.DescribeInitializationStatus_DataInitializationDetail>();
			for (int i = 0; i < _ctx.Length("DescribeInitializationStatus.DataInitializationDetails.Length"); i++) {
				DescribeInitializationStatusResponse.DescribeInitializationStatus_DataInitializationDetail dataInitializationDetail = new DescribeInitializationStatusResponse.DescribeInitializationStatus_DataInitializationDetail();
				dataInitializationDetail.DestinationOwnerDBName = _ctx.StringValue("DescribeInitializationStatus.DataInitializationDetails["+ i +"].DestinationOwnerDBName");
				dataInitializationDetail.ErrorMessage = _ctx.StringValue("DescribeInitializationStatus.DataInitializationDetails["+ i +"].ErrorMessage");
				dataInitializationDetail.FinishRowNum = _ctx.StringValue("DescribeInitializationStatus.DataInitializationDetails["+ i +"].FinishRowNum");
				dataInitializationDetail.SourceOwnerDBName = _ctx.StringValue("DescribeInitializationStatus.DataInitializationDetails["+ i +"].SourceOwnerDBName");
				dataInitializationDetail.Status = _ctx.StringValue("DescribeInitializationStatus.DataInitializationDetails["+ i +"].Status");
				dataInitializationDetail.TableName = _ctx.StringValue("DescribeInitializationStatus.DataInitializationDetails["+ i +"].TableName");
				dataInitializationDetail.TotalRowNum = _ctx.StringValue("DescribeInitializationStatus.DataInitializationDetails["+ i +"].TotalRowNum");
				dataInitializationDetail.UsedTime = _ctx.StringValue("DescribeInitializationStatus.DataInitializationDetails["+ i +"].UsedTime");

				describeInitializationStatusResponse_dataInitializationDetails.Add(dataInitializationDetail);
			}
			describeInitializationStatusResponse.DataInitializationDetails = describeInitializationStatusResponse_dataInitializationDetails;

			List<DescribeInitializationStatusResponse.DescribeInitializationStatus_DataSynchronizationDetail> describeInitializationStatusResponse_dataSynchronizationDetails = new List<DescribeInitializationStatusResponse.DescribeInitializationStatus_DataSynchronizationDetail>();
			for (int i = 0; i < _ctx.Length("DescribeInitializationStatus.DataSynchronizationDetails.Length"); i++) {
				DescribeInitializationStatusResponse.DescribeInitializationStatus_DataSynchronizationDetail dataSynchronizationDetail = new DescribeInitializationStatusResponse.DescribeInitializationStatus_DataSynchronizationDetail();
				dataSynchronizationDetail.DestinationOwnerDBName = _ctx.StringValue("DescribeInitializationStatus.DataSynchronizationDetails["+ i +"].DestinationOwnerDBName");
				dataSynchronizationDetail.ErrorMessage = _ctx.StringValue("DescribeInitializationStatus.DataSynchronizationDetails["+ i +"].ErrorMessage");
				dataSynchronizationDetail.SourceOwnerDBName = _ctx.StringValue("DescribeInitializationStatus.DataSynchronizationDetails["+ i +"].SourceOwnerDBName");
				dataSynchronizationDetail.Status = _ctx.StringValue("DescribeInitializationStatus.DataSynchronizationDetails["+ i +"].Status");
				dataSynchronizationDetail.TableName = _ctx.StringValue("DescribeInitializationStatus.DataSynchronizationDetails["+ i +"].TableName");

				describeInitializationStatusResponse_dataSynchronizationDetails.Add(dataSynchronizationDetail);
			}
			describeInitializationStatusResponse.DataSynchronizationDetails = describeInitializationStatusResponse_dataSynchronizationDetails;

			List<DescribeInitializationStatusResponse.DescribeInitializationStatus_StructureInitializationDetail> describeInitializationStatusResponse_structureInitializationDetails = new List<DescribeInitializationStatusResponse.DescribeInitializationStatus_StructureInitializationDetail>();
			for (int i = 0; i < _ctx.Length("DescribeInitializationStatus.StructureInitializationDetails.Length"); i++) {
				DescribeInitializationStatusResponse.DescribeInitializationStatus_StructureInitializationDetail structureInitializationDetail = new DescribeInitializationStatusResponse.DescribeInitializationStatus_StructureInitializationDetail();
				structureInitializationDetail.DestinationOwnerDBName = _ctx.StringValue("DescribeInitializationStatus.StructureInitializationDetails["+ i +"].DestinationOwnerDBName");
				structureInitializationDetail.ErrorMessage = _ctx.StringValue("DescribeInitializationStatus.StructureInitializationDetails["+ i +"].ErrorMessage");
				structureInitializationDetail.ObjectDefinition = _ctx.StringValue("DescribeInitializationStatus.StructureInitializationDetails["+ i +"].ObjectDefinition");
				structureInitializationDetail.ObjectName = _ctx.StringValue("DescribeInitializationStatus.StructureInitializationDetails["+ i +"].ObjectName");
				structureInitializationDetail.ObjectType = _ctx.StringValue("DescribeInitializationStatus.StructureInitializationDetails["+ i +"].ObjectType");
				structureInitializationDetail.SourceOwnerDBName = _ctx.StringValue("DescribeInitializationStatus.StructureInitializationDetails["+ i +"].SourceOwnerDBName");
				structureInitializationDetail.Status = _ctx.StringValue("DescribeInitializationStatus.StructureInitializationDetails["+ i +"].Status");

				List<DescribeInitializationStatusResponse.DescribeInitializationStatus_StructureInitializationDetail.DescribeInitializationStatus_StructureInitializationDetail1> structureInitializationDetail_constraints = new List<DescribeInitializationStatusResponse.DescribeInitializationStatus_StructureInitializationDetail.DescribeInitializationStatus_StructureInitializationDetail1>();
				for (int j = 0; j < _ctx.Length("DescribeInitializationStatus.StructureInitializationDetails["+ i +"].Constraints.Length"); j++) {
					DescribeInitializationStatusResponse.DescribeInitializationStatus_StructureInitializationDetail.DescribeInitializationStatus_StructureInitializationDetail1 structureInitializationDetail1 = new DescribeInitializationStatusResponse.DescribeInitializationStatus_StructureInitializationDetail.DescribeInitializationStatus_StructureInitializationDetail1();
					structureInitializationDetail1.DestinationOwnerDBName = _ctx.StringValue("DescribeInitializationStatus.StructureInitializationDetails["+ i +"].Constraints["+ j +"].DestinationOwnerDBName");
					structureInitializationDetail1.ErrorMessage = _ctx.StringValue("DescribeInitializationStatus.StructureInitializationDetails["+ i +"].Constraints["+ j +"].ErrorMessage");
					structureInitializationDetail1.ObjectDefinition = _ctx.StringValue("DescribeInitializationStatus.StructureInitializationDetails["+ i +"].Constraints["+ j +"].ObjectDefinition");
					structureInitializationDetail1.ObjectName = _ctx.StringValue("DescribeInitializationStatus.StructureInitializationDetails["+ i +"].Constraints["+ j +"].ObjectName");
					structureInitializationDetail1.ObjectType = _ctx.StringValue("DescribeInitializationStatus.StructureInitializationDetails["+ i +"].Constraints["+ j +"].ObjectType");
					structureInitializationDetail1.SourceOwnerDBName = _ctx.StringValue("DescribeInitializationStatus.StructureInitializationDetails["+ i +"].Constraints["+ j +"].SourceOwnerDBName");
					structureInitializationDetail1.Status = _ctx.StringValue("DescribeInitializationStatus.StructureInitializationDetails["+ i +"].Constraints["+ j +"].Status");

					structureInitializationDetail_constraints.Add(structureInitializationDetail1);
				}
				structureInitializationDetail.Constraints = structureInitializationDetail_constraints;

				describeInitializationStatusResponse_structureInitializationDetails.Add(structureInitializationDetail);
			}
			describeInitializationStatusResponse.StructureInitializationDetails = describeInitializationStatusResponse_structureInitializationDetails;
        
			return describeInitializationStatusResponse;
        }
    }
}
