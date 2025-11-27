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
using Aliyun.Acs.eds_user.Model.V20210308;

namespace Aliyun.Acs.eds_user.Transform.V20210308
{
    public class CreatePropertyResponseUnmarshaller
    {
        public static CreatePropertyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreatePropertyResponse createPropertyResponse = new CreatePropertyResponse();

			createPropertyResponse.HttpResponse = _ctx.HttpResponse;
			createPropertyResponse.RequestId = _ctx.StringValue("CreateProperty.RequestId");

			CreatePropertyResponse.CreateProperty_CreateResult createResult = new CreatePropertyResponse.CreateProperty_CreateResult();
			createResult.PropertyId = _ctx.LongValue("CreateProperty.CreateResult.PropertyId");
			createResult.PropertyKey = _ctx.StringValue("CreateProperty.CreateResult.PropertyKey");

			CreatePropertyResponse.CreateProperty_CreateResult.CreateProperty_SavePropertyValueModel savePropertyValueModel = new CreatePropertyResponse.CreateProperty_CreateResult.CreateProperty_SavePropertyValueModel();

			List<CreatePropertyResponse.CreateProperty_CreateResult.CreateProperty_SavePropertyValueModel.CreateProperty_SavePropertyValuesItem> savePropertyValueModel_savePropertyValues = new List<CreatePropertyResponse.CreateProperty_CreateResult.CreateProperty_SavePropertyValueModel.CreateProperty_SavePropertyValuesItem>();
			for (int i = 0; i < _ctx.Length("CreateProperty.CreateResult.SavePropertyValueModel.SavePropertyValues.Length"); i++) {
				CreatePropertyResponse.CreateProperty_CreateResult.CreateProperty_SavePropertyValueModel.CreateProperty_SavePropertyValuesItem savePropertyValuesItem = new CreatePropertyResponse.CreateProperty_CreateResult.CreateProperty_SavePropertyValueModel.CreateProperty_SavePropertyValuesItem();
				savePropertyValuesItem.PropertyValueId = _ctx.LongValue("CreateProperty.CreateResult.SavePropertyValueModel.SavePropertyValues["+ i +"].PropertyValueId");
				savePropertyValuesItem.PropertyValue = _ctx.StringValue("CreateProperty.CreateResult.SavePropertyValueModel.SavePropertyValues["+ i +"].PropertyValue");

				savePropertyValueModel_savePropertyValues.Add(savePropertyValuesItem);
			}
			savePropertyValueModel.SavePropertyValues = savePropertyValueModel_savePropertyValues;

			List<CreatePropertyResponse.CreateProperty_CreateResult.CreateProperty_SavePropertyValueModel.CreateProperty_FailedPropertyValuesItem> savePropertyValueModel_failedPropertyValues = new List<CreatePropertyResponse.CreateProperty_CreateResult.CreateProperty_SavePropertyValueModel.CreateProperty_FailedPropertyValuesItem>();
			for (int i = 0; i < _ctx.Length("CreateProperty.CreateResult.SavePropertyValueModel.FailedPropertyValues.Length"); i++) {
				CreatePropertyResponse.CreateProperty_CreateResult.CreateProperty_SavePropertyValueModel.CreateProperty_FailedPropertyValuesItem failedPropertyValuesItem = new CreatePropertyResponse.CreateProperty_CreateResult.CreateProperty_SavePropertyValueModel.CreateProperty_FailedPropertyValuesItem();
				failedPropertyValuesItem.PropertyId = _ctx.LongValue("CreateProperty.CreateResult.SavePropertyValueModel.FailedPropertyValues["+ i +"].PropertyId");
				failedPropertyValuesItem.PropertyValue = _ctx.StringValue("CreateProperty.CreateResult.SavePropertyValueModel.FailedPropertyValues["+ i +"].PropertyValue");
				failedPropertyValuesItem.ErrorCode = _ctx.StringValue("CreateProperty.CreateResult.SavePropertyValueModel.FailedPropertyValues["+ i +"].ErrorCode");
				failedPropertyValuesItem.ErrorMessage = _ctx.StringValue("CreateProperty.CreateResult.SavePropertyValueModel.FailedPropertyValues["+ i +"].ErrorMessage");

				savePropertyValueModel_failedPropertyValues.Add(failedPropertyValuesItem);
			}
			savePropertyValueModel.FailedPropertyValues = savePropertyValueModel_failedPropertyValues;
			createResult.SavePropertyValueModel = savePropertyValueModel;
			createPropertyResponse.CreateResult = createResult;
        
			return createPropertyResponse;
        }
    }
}
