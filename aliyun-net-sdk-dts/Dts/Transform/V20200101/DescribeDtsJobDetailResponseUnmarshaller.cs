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
    public class DescribeDtsJobDetailResponseUnmarshaller
    {
        public static DescribeDtsJobDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDtsJobDetailResponse describeDtsJobDetailResponse = new DescribeDtsJobDetailResponse();

			describeDtsJobDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeDtsJobDetailResponse.RequestId = _ctx.StringValue("DescribeDtsJobDetail.RequestId");
			describeDtsJobDetailResponse.Success = _ctx.BooleanValue("DescribeDtsJobDetail.Success");
			describeDtsJobDetailResponse.Code = _ctx.IntegerValue("DescribeDtsJobDetail.Code");
			describeDtsJobDetailResponse.ErrCode = _ctx.StringValue("DescribeDtsJobDetail.ErrCode");
			describeDtsJobDetailResponse.ErrMessage = _ctx.StringValue("DescribeDtsJobDetail.ErrMessage");
			describeDtsJobDetailResponse.DynamicMessage = _ctx.StringValue("DescribeDtsJobDetail.DynamicMessage");
			describeDtsJobDetailResponse.HttpStatusCode = _ctx.IntegerValue("DescribeDtsJobDetail.HttpStatusCode");
			describeDtsJobDetailResponse.DtsInstanceID = _ctx.StringValue("DescribeDtsJobDetail.DtsInstanceID");
			describeDtsJobDetailResponse.DtsJobId = _ctx.StringValue("DescribeDtsJobDetail.DtsJobId");
			describeDtsJobDetailResponse.DtsJobName = _ctx.StringValue("DescribeDtsJobDetail.DtsJobName");
			describeDtsJobDetailResponse.DtsJobClass = _ctx.StringValue("DescribeDtsJobDetail.DtsJobClass");
			describeDtsJobDetailResponse.DtsJobDirection = _ctx.StringValue("DescribeDtsJobDetail.DtsJobDirection");
			describeDtsJobDetailResponse.PayType = _ctx.StringValue("DescribeDtsJobDetail.PayType");
			describeDtsJobDetailResponse.ExpireTime = _ctx.StringValue("DescribeDtsJobDetail.ExpireTime");
			describeDtsJobDetailResponse.CreateTime = _ctx.StringValue("DescribeDtsJobDetail.CreateTime");
			describeDtsJobDetailResponse.FinishTime = _ctx.StringValue("DescribeDtsJobDetail.FinishTime");
			describeDtsJobDetailResponse.Status = _ctx.StringValue("DescribeDtsJobDetail.Status");
			describeDtsJobDetailResponse.Checkpoint = _ctx.IntegerValue("DescribeDtsJobDetail.Checkpoint");
			describeDtsJobDetailResponse.Delay = _ctx.IntegerValue("DescribeDtsJobDetail.Delay");
			describeDtsJobDetailResponse.Reserved = _ctx.StringValue("DescribeDtsJobDetail.Reserved");
			describeDtsJobDetailResponse.ErrorMessage = _ctx.StringValue("DescribeDtsJobDetail.ErrorMessage");
			describeDtsJobDetailResponse.DbObject = _ctx.StringValue("DescribeDtsJobDetail.DbObject");
			describeDtsJobDetailResponse.SynchronizationDirection = _ctx.StringValue("DescribeDtsJobDetail.SynchronizationDirection");
			describeDtsJobDetailResponse.EtlCalculator = _ctx.StringValue("DescribeDtsJobDetail.EtlCalculator");
			describeDtsJobDetailResponse.GroupId = _ctx.StringValue("DescribeDtsJobDetail.GroupId");
			describeDtsJobDetailResponse.DatabaseCount = _ctx.IntegerValue("DescribeDtsJobDetail.DatabaseCount");
			describeDtsJobDetailResponse.SubscribeTopic = _ctx.StringValue("DescribeDtsJobDetail.SubscribeTopic");
			describeDtsJobDetailResponse.ConsumptionCheckpoint = _ctx.StringValue("DescribeDtsJobDetail.ConsumptionCheckpoint");
			describeDtsJobDetailResponse.BeginTimestamp = _ctx.StringValue("DescribeDtsJobDetail.BeginTimestamp");
			describeDtsJobDetailResponse.EndTimestamp = _ctx.StringValue("DescribeDtsJobDetail.EndTimestamp");
			describeDtsJobDetailResponse.ConsumptionClient = _ctx.StringValue("DescribeDtsJobDetail.ConsumptionClient");
			describeDtsJobDetailResponse.AppName = _ctx.StringValue("DescribeDtsJobDetail.AppName");
			describeDtsJobDetailResponse.DestNetType = _ctx.StringValue("DescribeDtsJobDetail.DestNetType");

			DescribeDtsJobDetailResponse.DescribeDtsJobDetail_SourceEndpoint sourceEndpoint = new DescribeDtsJobDetailResponse.DescribeDtsJobDetail_SourceEndpoint();
			sourceEndpoint.InstanceID = _ctx.StringValue("DescribeDtsJobDetail.SourceEndpoint.InstanceID");
			sourceEndpoint.Region = _ctx.StringValue("DescribeDtsJobDetail.SourceEndpoint.Region");
			sourceEndpoint.InstanceType = _ctx.StringValue("DescribeDtsJobDetail.SourceEndpoint.InstanceType");
			sourceEndpoint.EngineName = _ctx.StringValue("DescribeDtsJobDetail.SourceEndpoint.EngineName");
			sourceEndpoint.Ip = _ctx.StringValue("DescribeDtsJobDetail.SourceEndpoint.Ip");
			sourceEndpoint.Port = _ctx.StringValue("DescribeDtsJobDetail.SourceEndpoint.Port");
			sourceEndpoint.DatabaseName = _ctx.StringValue("DescribeDtsJobDetail.SourceEndpoint.DatabaseName");
			sourceEndpoint.OracleSID = _ctx.StringValue("DescribeDtsJobDetail.SourceEndpoint.OracleSID");
			sourceEndpoint.UserName = _ctx.StringValue("DescribeDtsJobDetail.SourceEndpoint.UserName");
			sourceEndpoint.SslSolutionEnum = _ctx.StringValue("DescribeDtsJobDetail.SourceEndpoint.SslSolutionEnum");
			sourceEndpoint.RoleName = _ctx.StringValue("DescribeDtsJobDetail.SourceEndpoint.RoleName");
			sourceEndpoint.AliyunUid = _ctx.StringValue("DescribeDtsJobDetail.SourceEndpoint.AliyunUid");
			describeDtsJobDetailResponse.SourceEndpoint = sourceEndpoint;

			DescribeDtsJobDetailResponse.DescribeDtsJobDetail_DestinationEndpoint destinationEndpoint = new DescribeDtsJobDetailResponse.DescribeDtsJobDetail_DestinationEndpoint();
			destinationEndpoint.InstanceID = _ctx.StringValue("DescribeDtsJobDetail.DestinationEndpoint.InstanceID");
			destinationEndpoint.Region = _ctx.StringValue("DescribeDtsJobDetail.DestinationEndpoint.Region");
			destinationEndpoint.InstanceType = _ctx.StringValue("DescribeDtsJobDetail.DestinationEndpoint.InstanceType");
			destinationEndpoint.EngineName = _ctx.StringValue("DescribeDtsJobDetail.DestinationEndpoint.EngineName");
			destinationEndpoint.Ip = _ctx.StringValue("DescribeDtsJobDetail.DestinationEndpoint.Ip");
			destinationEndpoint.Port = _ctx.StringValue("DescribeDtsJobDetail.DestinationEndpoint.Port");
			destinationEndpoint.DatabaseName = _ctx.StringValue("DescribeDtsJobDetail.DestinationEndpoint.DatabaseName");
			destinationEndpoint.OracleSID = _ctx.StringValue("DescribeDtsJobDetail.DestinationEndpoint.OracleSID");
			destinationEndpoint.UserName = _ctx.StringValue("DescribeDtsJobDetail.DestinationEndpoint.UserName");
			destinationEndpoint.SslSolutionEnum = _ctx.StringValue("DescribeDtsJobDetail.DestinationEndpoint.SslSolutionEnum");
			describeDtsJobDetailResponse.DestinationEndpoint = destinationEndpoint;

			DescribeDtsJobDetailResponse.DescribeDtsJobDetail_MigrationMode migrationMode = new DescribeDtsJobDetailResponse.DescribeDtsJobDetail_MigrationMode();
			migrationMode.StructureInitialization = _ctx.BooleanValue("DescribeDtsJobDetail.MigrationMode.StructureInitialization");
			migrationMode.DataInitialization = _ctx.BooleanValue("DescribeDtsJobDetail.MigrationMode.DataInitialization");
			migrationMode.DataSynchronization = _ctx.BooleanValue("DescribeDtsJobDetail.MigrationMode.DataSynchronization");
			migrationMode.DataExtractTransformLoad = _ctx.BooleanValue("DescribeDtsJobDetail.MigrationMode.DataExtractTransformLoad");
			describeDtsJobDetailResponse.MigrationMode = migrationMode;

			DescribeDtsJobDetailResponse.DescribeDtsJobDetail_SubscriptionHost subscriptionHost = new DescribeDtsJobDetailResponse.DescribeDtsJobDetail_SubscriptionHost();
			subscriptionHost.PublicHost = _ctx.StringValue("DescribeDtsJobDetail.SubscriptionHost.PublicHost");
			subscriptionHost.PrivateHost = _ctx.StringValue("DescribeDtsJobDetail.SubscriptionHost.PrivateHost");
			subscriptionHost.VpcHost = _ctx.StringValue("DescribeDtsJobDetail.SubscriptionHost.VpcHost");
			describeDtsJobDetailResponse.SubscriptionHost = subscriptionHost;

			DescribeDtsJobDetailResponse.DescribeDtsJobDetail_SubscriptionDataType subscriptionDataType = new DescribeDtsJobDetailResponse.DescribeDtsJobDetail_SubscriptionDataType();
			subscriptionDataType.Ddl = _ctx.BooleanValue("DescribeDtsJobDetail.SubscriptionDataType.Ddl");
			subscriptionDataType.Dml = _ctx.BooleanValue("DescribeDtsJobDetail.SubscriptionDataType.Dml");
			describeDtsJobDetailResponse.SubscriptionDataType = subscriptionDataType;
        
			return describeDtsJobDetailResponse;
        }
    }
}
