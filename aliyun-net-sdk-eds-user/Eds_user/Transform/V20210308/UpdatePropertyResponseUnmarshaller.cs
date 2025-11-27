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
    public class UpdatePropertyResponseUnmarshaller
    {
        public static UpdatePropertyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdatePropertyResponse updatePropertyResponse = new UpdatePropertyResponse();

			updatePropertyResponse.HttpResponse = _ctx.HttpResponse;
			updatePropertyResponse.RequestId = _ctx.StringValue("UpdateProperty.RequestId");

			UpdatePropertyResponse.UpdateProperty_UpdateResult updateResult = new UpdatePropertyResponse.UpdateProperty_UpdateResult();
			updateResult.PropertyId = _ctx.LongValue("UpdateProperty.UpdateResult.PropertyId");
			updateResult.PropertyKey = _ctx.StringValue("UpdateProperty.UpdateResult.PropertyKey");

			UpdatePropertyResponse.UpdateProperty_UpdateResult.UpdateProperty_SavePropertyValueModel savePropertyValueModel = new UpdatePropertyResponse.UpdateProperty_UpdateResult.UpdateProperty_SavePropertyValueModel();

			List<UpdatePropertyResponse.UpdateProperty_UpdateResult.UpdateProperty_SavePropertyValueModel.UpdateProperty_SavePropertyValuesItem> savePropertyValueModel_savePropertyValues = new List<UpdatePropertyResponse.UpdateProperty_UpdateResult.UpdateProperty_SavePropertyValueModel.UpdateProperty_SavePropertyValuesItem>();
			for (int i = 0; i < _ctx.Length("UpdateProperty.UpdateResult.SavePropertyValueModel.SavePropertyValues.Length"); i++) {
				UpdatePropertyResponse.UpdateProperty_UpdateResult.UpdateProperty_SavePropertyValueModel.UpdateProperty_SavePropertyValuesItem savePropertyValuesItem = new UpdatePropertyResponse.UpdateProperty_UpdateResult.UpdateProperty_SavePropertyValueModel.UpdateProperty_SavePropertyValuesItem();
				savePropertyValuesItem.PropertyValueId = _ctx.LongValue("UpdateProperty.UpdateResult.SavePropertyValueModel.SavePropertyValues["+ i +"].PropertyValueId");
				savePropertyValuesItem.PropertyValue = _ctx.StringValue("UpdateProperty.UpdateResult.SavePropertyValueModel.SavePropertyValues["+ i +"].PropertyValue");

				savePropertyValueModel_savePropertyValues.Add(savePropertyValuesItem);
			}
			savePropertyValueModel.SavePropertyValues = savePropertyValueModel_savePropertyValues;

			List<UpdatePropertyResponse.UpdateProperty_UpdateResult.UpdateProperty_SavePropertyValueModel.UpdateProperty_FailedPropertyValuesItem> savePropertyValueModel_failedPropertyValues = new List<UpdatePropertyResponse.UpdateProperty_UpdateResult.UpdateProperty_SavePropertyValueModel.UpdateProperty_FailedPropertyValuesItem>();
			for (int i = 0; i < _ctx.Length("UpdateProperty.UpdateResult.SavePropertyValueModel.FailedPropertyValues.Length"); i++) {
				UpdatePropertyResponse.UpdateProperty_UpdateResult.UpdateProperty_SavePropertyValueModel.UpdateProperty_FailedPropertyValuesItem failedPropertyValuesItem = new UpdatePropertyResponse.UpdateProperty_UpdateResult.UpdateProperty_SavePropertyValueModel.UpdateProperty_FailedPropertyValuesItem();
				failedPropertyValuesItem.PropertyId = _ctx.LongValue("UpdateProperty.UpdateResult.SavePropertyValueModel.FailedPropertyValues["+ i +"].PropertyId");
				failedPropertyValuesItem.PropertyValue = _ctx.StringValue("UpdateProperty.UpdateResult.SavePropertyValueModel.FailedPropertyValues["+ i +"].PropertyValue");
				failedPropertyValuesItem.ErrorCode = _ctx.StringValue("UpdateProperty.UpdateResult.SavePropertyValueModel.FailedPropertyValues["+ i +"].ErrorCode");
				failedPropertyValuesItem.ErrorMessage = _ctx.StringValue("UpdateProperty.UpdateResult.SavePropertyValueModel.FailedPropertyValues["+ i +"].ErrorMessage");

				savePropertyValueModel_failedPropertyValues.Add(failedPropertyValuesItem);
			}
			savePropertyValueModel.FailedPropertyValues = savePropertyValueModel_failedPropertyValues;
			updateResult.SavePropertyValueModel = savePropertyValueModel;
			updatePropertyResponse.UpdateResult = updateResult;
        
			return updatePropertyResponse;
        }
    }
}
