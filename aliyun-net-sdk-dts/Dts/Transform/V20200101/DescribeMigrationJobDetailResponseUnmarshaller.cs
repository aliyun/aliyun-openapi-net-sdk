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
    public class DescribeMigrationJobDetailResponseUnmarshaller
    {
        public static DescribeMigrationJobDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMigrationJobDetailResponse describeMigrationJobDetailResponse = new DescribeMigrationJobDetailResponse();

			describeMigrationJobDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeMigrationJobDetailResponse.ErrCode = _ctx.StringValue("DescribeMigrationJobDetail.ErrCode");
			describeMigrationJobDetailResponse.ErrMessage = _ctx.StringValue("DescribeMigrationJobDetail.ErrMessage");
			describeMigrationJobDetailResponse.PageNumber = _ctx.IntegerValue("DescribeMigrationJobDetail.PageNumber");
			describeMigrationJobDetailResponse.PageRecordCount = _ctx.IntegerValue("DescribeMigrationJobDetail.PageRecordCount");
			describeMigrationJobDetailResponse.RequestId = _ctx.StringValue("DescribeMigrationJobDetail.RequestId");
			describeMigrationJobDetailResponse.Success = _ctx.StringValue("DescribeMigrationJobDetail.Success");
			describeMigrationJobDetailResponse.TotalRecordCount = _ctx.LongValue("DescribeMigrationJobDetail.TotalRecordCount");

			List<DescribeMigrationJobDetailResponse.DescribeMigrationJobDetail_DataInitializationDetail> describeMigrationJobDetailResponse_dataInitializationDetailList = new List<DescribeMigrationJobDetailResponse.DescribeMigrationJobDetail_DataInitializationDetail>();
			for (int i = 0; i < _ctx.Length("DescribeMigrationJobDetail.DataInitializationDetailList.Length"); i++) {
				DescribeMigrationJobDetailResponse.DescribeMigrationJobDetail_DataInitializationDetail dataInitializationDetail = new DescribeMigrationJobDetailResponse.DescribeMigrationJobDetail_DataInitializationDetail();
				dataInitializationDetail.DestinationOwnerDBName = _ctx.StringValue("DescribeMigrationJobDetail.DataInitializationDetailList["+ i +"].DestinationOwnerDBName");
				dataInitializationDetail.ErrorMessage = _ctx.StringValue("DescribeMigrationJobDetail.DataInitializationDetailList["+ i +"].ErrorMessage");
				dataInitializationDetail.FinishRowNum = _ctx.StringValue("DescribeMigrationJobDetail.DataInitializationDetailList["+ i +"].FinishRowNum");
				dataInitializationDetail.MigrationTime = _ctx.StringValue("DescribeMigrationJobDetail.DataInitializationDetailList["+ i +"].MigrationTime");
				dataInitializationDetail.SourceOwnerDBName = _ctx.StringValue("DescribeMigrationJobDetail.DataInitializationDetailList["+ i +"].SourceOwnerDBName");
				dataInitializationDetail.Status = _ctx.StringValue("DescribeMigrationJobDetail.DataInitializationDetailList["+ i +"].Status");
				dataInitializationDetail.TableName = _ctx.StringValue("DescribeMigrationJobDetail.DataInitializationDetailList["+ i +"].TableName");
				dataInitializationDetail.TotalRowNum = _ctx.StringValue("DescribeMigrationJobDetail.DataInitializationDetailList["+ i +"].TotalRowNum");

				describeMigrationJobDetailResponse_dataInitializationDetailList.Add(dataInitializationDetail);
			}
			describeMigrationJobDetailResponse.DataInitializationDetailList = describeMigrationJobDetailResponse_dataInitializationDetailList;

			List<DescribeMigrationJobDetailResponse.DescribeMigrationJobDetail_DataSynchronizationDetail> describeMigrationJobDetailResponse_dataSynchronizationDetailList = new List<DescribeMigrationJobDetailResponse.DescribeMigrationJobDetail_DataSynchronizationDetail>();
			for (int i = 0; i < _ctx.Length("DescribeMigrationJobDetail.DataSynchronizationDetailList.Length"); i++) {
				DescribeMigrationJobDetailResponse.DescribeMigrationJobDetail_DataSynchronizationDetail dataSynchronizationDetail = new DescribeMigrationJobDetailResponse.DescribeMigrationJobDetail_DataSynchronizationDetail();
				dataSynchronizationDetail.DestinationOwnerDBName = _ctx.StringValue("DescribeMigrationJobDetail.DataSynchronizationDetailList["+ i +"].DestinationOwnerDBName");
				dataSynchronizationDetail.ErrorMessage = _ctx.StringValue("DescribeMigrationJobDetail.DataSynchronizationDetailList["+ i +"].ErrorMessage");
				dataSynchronizationDetail.SourceOwnerDBName = _ctx.StringValue("DescribeMigrationJobDetail.DataSynchronizationDetailList["+ i +"].SourceOwnerDBName");
				dataSynchronizationDetail.Status = _ctx.StringValue("DescribeMigrationJobDetail.DataSynchronizationDetailList["+ i +"].Status");
				dataSynchronizationDetail.TableName = _ctx.StringValue("DescribeMigrationJobDetail.DataSynchronizationDetailList["+ i +"].TableName");

				describeMigrationJobDetailResponse_dataSynchronizationDetailList.Add(dataSynchronizationDetail);
			}
			describeMigrationJobDetailResponse.DataSynchronizationDetailList = describeMigrationJobDetailResponse_dataSynchronizationDetailList;

			List<DescribeMigrationJobDetailResponse.DescribeMigrationJobDetail_StructureInitializationDetail> describeMigrationJobDetailResponse_structureInitializationDetailList = new List<DescribeMigrationJobDetailResponse.DescribeMigrationJobDetail_StructureInitializationDetail>();
			for (int i = 0; i < _ctx.Length("DescribeMigrationJobDetail.StructureInitializationDetailList.Length"); i++) {
				DescribeMigrationJobDetailResponse.DescribeMigrationJobDetail_StructureInitializationDetail structureInitializationDetail = new DescribeMigrationJobDetailResponse.DescribeMigrationJobDetail_StructureInitializationDetail();
				structureInitializationDetail.DestinationOwnerDBName = _ctx.StringValue("DescribeMigrationJobDetail.StructureInitializationDetailList["+ i +"].DestinationOwnerDBName");
				structureInitializationDetail.ErrorMessage = _ctx.StringValue("DescribeMigrationJobDetail.StructureInitializationDetailList["+ i +"].ErrorMessage");
				structureInitializationDetail.ObjectDefinition = _ctx.StringValue("DescribeMigrationJobDetail.StructureInitializationDetailList["+ i +"].ObjectDefinition");
				structureInitializationDetail.ObjectName = _ctx.StringValue("DescribeMigrationJobDetail.StructureInitializationDetailList["+ i +"].ObjectName");
				structureInitializationDetail.ObjectType = _ctx.StringValue("DescribeMigrationJobDetail.StructureInitializationDetailList["+ i +"].ObjectType");
				structureInitializationDetail.SourceOwnerDBName = _ctx.StringValue("DescribeMigrationJobDetail.StructureInitializationDetailList["+ i +"].SourceOwnerDBName");
				structureInitializationDetail.Status = _ctx.StringValue("DescribeMigrationJobDetail.StructureInitializationDetailList["+ i +"].Status");

				List<DescribeMigrationJobDetailResponse.DescribeMigrationJobDetail_StructureInitializationDetail.DescribeMigrationJobDetail_StructureInitializationDetail1> structureInitializationDetail_constraintList = new List<DescribeMigrationJobDetailResponse.DescribeMigrationJobDetail_StructureInitializationDetail.DescribeMigrationJobDetail_StructureInitializationDetail1>();
				for (int j = 0; j < _ctx.Length("DescribeMigrationJobDetail.StructureInitializationDetailList["+ i +"].ConstraintList.Length"); j++) {
					DescribeMigrationJobDetailResponse.DescribeMigrationJobDetail_StructureInitializationDetail.DescribeMigrationJobDetail_StructureInitializationDetail1 structureInitializationDetail1 = new DescribeMigrationJobDetailResponse.DescribeMigrationJobDetail_StructureInitializationDetail.DescribeMigrationJobDetail_StructureInitializationDetail1();
					structureInitializationDetail1.DestinationOwnerDBName = _ctx.StringValue("DescribeMigrationJobDetail.StructureInitializationDetailList["+ i +"].ConstraintList["+ j +"].DestinationOwnerDBName");
					structureInitializationDetail1.ErrorMessage = _ctx.StringValue("DescribeMigrationJobDetail.StructureInitializationDetailList["+ i +"].ConstraintList["+ j +"].ErrorMessage");
					structureInitializationDetail1.ObjectDefinition = _ctx.StringValue("DescribeMigrationJobDetail.StructureInitializationDetailList["+ i +"].ConstraintList["+ j +"].ObjectDefinition");
					structureInitializationDetail1.ObjectName = _ctx.StringValue("DescribeMigrationJobDetail.StructureInitializationDetailList["+ i +"].ConstraintList["+ j +"].ObjectName");
					structureInitializationDetail1.ObjectType = _ctx.StringValue("DescribeMigrationJobDetail.StructureInitializationDetailList["+ i +"].ConstraintList["+ j +"].ObjectType");
					structureInitializationDetail1.SourceOwnerDBName = _ctx.StringValue("DescribeMigrationJobDetail.StructureInitializationDetailList["+ i +"].ConstraintList["+ j +"].SourceOwnerDBName");
					structureInitializationDetail1.Status = _ctx.StringValue("DescribeMigrationJobDetail.StructureInitializationDetailList["+ i +"].ConstraintList["+ j +"].Status");

					structureInitializationDetail_constraintList.Add(structureInitializationDetail1);
				}
				structureInitializationDetail.ConstraintList = structureInitializationDetail_constraintList;

				describeMigrationJobDetailResponse_structureInitializationDetailList.Add(structureInitializationDetail);
			}
			describeMigrationJobDetailResponse.StructureInitializationDetailList = describeMigrationJobDetailResponse_structureInitializationDetailList;
        
			return describeMigrationJobDetailResponse;
        }
    }
}
