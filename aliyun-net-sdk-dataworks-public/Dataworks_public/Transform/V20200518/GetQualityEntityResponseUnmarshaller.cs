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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetQualityEntityResponseUnmarshaller
    {
        public static GetQualityEntityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetQualityEntityResponse getQualityEntityResponse = new GetQualityEntityResponse();

			getQualityEntityResponse.HttpResponse = _ctx.HttpResponse;
			getQualityEntityResponse.Success = _ctx.BooleanValue("GetQualityEntity.Success");
			getQualityEntityResponse.ErrorCode = _ctx.StringValue("GetQualityEntity.ErrorCode");
			getQualityEntityResponse.ErrorMessage = _ctx.StringValue("GetQualityEntity.ErrorMessage");
			getQualityEntityResponse.HttpStatusCode = _ctx.IntegerValue("GetQualityEntity.HttpStatusCode");
			getQualityEntityResponse.RequestId = _ctx.StringValue("GetQualityEntity.RequestId");

			List<GetQualityEntityResponse.GetQualityEntity_EntityDto> getQualityEntityResponse_data = new List<GetQualityEntityResponse.GetQualityEntity_EntityDto>();
			for (int i = 0; i < _ctx.Length("GetQualityEntity.Data.Length"); i++) {
				GetQualityEntityResponse.GetQualityEntity_EntityDto entityDto = new GetQualityEntityResponse.GetQualityEntity_EntityDto();
				entityDto.Id = _ctx.LongValue("GetQualityEntity.Data["+ i +"].Id");
				entityDto.ProjectName = _ctx.StringValue("GetQualityEntity.Data["+ i +"].ProjectName");
				entityDto.TableName = _ctx.StringValue("GetQualityEntity.Data["+ i +"].TableName");
				entityDto.EnvType = _ctx.StringValue("GetQualityEntity.Data["+ i +"].EnvType");
				entityDto.MatchExpression = _ctx.StringValue("GetQualityEntity.Data["+ i +"].MatchExpression");
				entityDto.EntityLevel = _ctx.IntegerValue("GetQualityEntity.Data["+ i +"].EntityLevel");
				entityDto.OnDuty = _ctx.StringValue("GetQualityEntity.Data["+ i +"].OnDuty");
				entityDto.ModifyUser = _ctx.StringValue("GetQualityEntity.Data["+ i +"].ModifyUser");
				entityDto.CreateTime = _ctx.LongValue("GetQualityEntity.Data["+ i +"].CreateTime");
				entityDto.ModifyTime = _ctx.LongValue("GetQualityEntity.Data["+ i +"].ModifyTime");
				entityDto.Sql = _ctx.IntegerValue("GetQualityEntity.Data["+ i +"].Sql");
				entityDto.Task = _ctx.IntegerValue("GetQualityEntity.Data["+ i +"].Task");
				entityDto.Followers = _ctx.StringValue("GetQualityEntity.Data["+ i +"].Followers");
				entityDto.HasRelativeNode = _ctx.BooleanValue("GetQualityEntity.Data["+ i +"].HasRelativeNode");
				entityDto.RelativeNode = _ctx.StringValue("GetQualityEntity.Data["+ i +"].RelativeNode");
				entityDto.OnDutyAccountName = _ctx.StringValue("GetQualityEntity.Data["+ i +"].OnDutyAccountName");

				getQualityEntityResponse_data.Add(entityDto);
			}
			getQualityEntityResponse.Data = getQualityEntityResponse_data;
        
			return getQualityEntityResponse;
        }
    }
}
