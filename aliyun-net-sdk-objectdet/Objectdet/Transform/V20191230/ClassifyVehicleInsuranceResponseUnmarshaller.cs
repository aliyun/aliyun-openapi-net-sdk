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
using Aliyun.Acs.objectdet.Model.V20191230;

namespace Aliyun.Acs.objectdet.Transform.V20191230
{
    public class ClassifyVehicleInsuranceResponseUnmarshaller
    {
        public static ClassifyVehicleInsuranceResponse Unmarshall(UnmarshallerContext context)
        {
			ClassifyVehicleInsuranceResponse classifyVehicleInsuranceResponse = new ClassifyVehicleInsuranceResponse();

			classifyVehicleInsuranceResponse.HttpResponse = context.HttpResponse;
			classifyVehicleInsuranceResponse.RequestId = context.StringValue("ClassifyVehicleInsurance.RequestId");

			ClassifyVehicleInsuranceResponse.ClassifyVehicleInsurance_Data data = new ClassifyVehicleInsuranceResponse.ClassifyVehicleInsurance_Data();
			data.Threshold = context.FloatValue("ClassifyVehicleInsurance.Data.Threshold");

			List<ClassifyVehicleInsuranceResponse.ClassifyVehicleInsurance_Data.ClassifyVehicleInsurance_Label> data_labels = new List<ClassifyVehicleInsuranceResponse.ClassifyVehicleInsurance_Data.ClassifyVehicleInsurance_Label>();
			for (int i = 0; i < context.Length("ClassifyVehicleInsurance.Data.Labels.Length"); i++) {
				ClassifyVehicleInsuranceResponse.ClassifyVehicleInsurance_Data.ClassifyVehicleInsurance_Label label = new ClassifyVehicleInsuranceResponse.ClassifyVehicleInsurance_Data.ClassifyVehicleInsurance_Label();
				label.Score = context.FloatValue("ClassifyVehicleInsurance.Data.Labels["+ i +"].Score");
				label.Name = context.StringValue("ClassifyVehicleInsurance.Data.Labels["+ i +"].Name");

				data_labels.Add(label);
			}
			data.Labels = data_labels;
			classifyVehicleInsuranceResponse.Data = data;
        
			return classifyVehicleInsuranceResponse;
        }
    }
}
