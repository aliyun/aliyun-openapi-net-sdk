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
using Aliyun.Acs.imageprocess.Model.V20200320;

namespace Aliyun.Acs.imageprocess.Transform.V20200320
{
    public class DetectSpineMRIResponseUnmarshaller
    {
        public static DetectSpineMRIResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectSpineMRIResponse detectSpineMRIResponse = new DetectSpineMRIResponse();

			detectSpineMRIResponse.HttpResponse = _ctx.HttpResponse;
			detectSpineMRIResponse.RequestId = _ctx.StringValue("DetectSpineMRI.RequestId");

			DetectSpineMRIResponse.DetectSpineMRI_Data data = new DetectSpineMRIResponse.DetectSpineMRI_Data();

			List<DetectSpineMRIResponse.DetectSpineMRI_Data.DetectSpineMRI_Disc> data_discs = new List<DetectSpineMRIResponse.DetectSpineMRI_Data.DetectSpineMRI_Disc>();
			for (int i = 0; i < _ctx.Length("DetectSpineMRI.Data.Discs.Length"); i++) {
				DetectSpineMRIResponse.DetectSpineMRI_Data.DetectSpineMRI_Disc disc = new DetectSpineMRIResponse.DetectSpineMRI_Data.DetectSpineMRI_Disc();
				disc.Disease = _ctx.StringValue("DetectSpineMRI.Data.Discs["+ i +"].Disease");
				disc.Identification = _ctx.StringValue("DetectSpineMRI.Data.Discs["+ i +"].Identification");

				List<string> disc_location = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectSpineMRI.Data.Discs["+ i +"].Location.Length"); j++) {
					disc_location.Add(_ctx.StringValue("DetectSpineMRI.Data.Discs["+ i +"].Location["+ j +"]"));
				}
				disc.Location = disc_location;

				data_discs.Add(disc);
			}
			data.Discs = data_discs;

			List<DetectSpineMRIResponse.DetectSpineMRI_Data.DetectSpineMRI_Vertebra> data_vertebras = new List<DetectSpineMRIResponse.DetectSpineMRI_Data.DetectSpineMRI_Vertebra>();
			for (int i = 0; i < _ctx.Length("DetectSpineMRI.Data.Vertebras.Length"); i++) {
				DetectSpineMRIResponse.DetectSpineMRI_Data.DetectSpineMRI_Vertebra vertebra = new DetectSpineMRIResponse.DetectSpineMRI_Data.DetectSpineMRI_Vertebra();
				vertebra.Disease = _ctx.StringValue("DetectSpineMRI.Data.Vertebras["+ i +"].Disease");
				vertebra.Identification = _ctx.StringValue("DetectSpineMRI.Data.Vertebras["+ i +"].Identification");

				List<string> vertebra_location1 = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectSpineMRI.Data.Vertebras["+ i +"].Location.Length"); j++) {
					vertebra_location1.Add(_ctx.StringValue("DetectSpineMRI.Data.Vertebras["+ i +"].Location["+ j +"]"));
				}
				vertebra.Location1 = vertebra_location1;

				data_vertebras.Add(vertebra);
			}
			data.Vertebras = data_vertebras;
			detectSpineMRIResponse.Data = data;
        
			return detectSpineMRIResponse;
        }
    }
}
