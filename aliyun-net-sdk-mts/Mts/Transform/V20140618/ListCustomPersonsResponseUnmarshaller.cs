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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class ListCustomPersonsResponseUnmarshaller
    {
        public static ListCustomPersonsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCustomPersonsResponse listCustomPersonsResponse = new ListCustomPersonsResponse();

			listCustomPersonsResponse.HttpResponse = _ctx.HttpResponse;
			listCustomPersonsResponse.RequestId = _ctx.StringValue("ListCustomPersons.RequestId");

			List<ListCustomPersonsResponse.ListCustomPersons_Category> listCustomPersonsResponse_categories = new List<ListCustomPersonsResponse.ListCustomPersons_Category>();
			for (int i = 0; i < _ctx.Length("ListCustomPersons.Categories.Length"); i++) {
				ListCustomPersonsResponse.ListCustomPersons_Category category = new ListCustomPersonsResponse.ListCustomPersons_Category();
				category.CategoryId = _ctx.StringValue("ListCustomPersons.Categories["+ i +"].CategoryId");
				category.CategoryName = _ctx.StringValue("ListCustomPersons.Categories["+ i +"].CategoryName");
				category.CategoryDescription = _ctx.StringValue("ListCustomPersons.Categories["+ i +"].CategoryDescription");

				List<ListCustomPersonsResponse.ListCustomPersons_Category.ListCustomPersons_Person> category_persons = new List<ListCustomPersonsResponse.ListCustomPersons_Category.ListCustomPersons_Person>();
				for (int j = 0; j < _ctx.Length("ListCustomPersons.Categories["+ i +"].Persons.Length"); j++) {
					ListCustomPersonsResponse.ListCustomPersons_Category.ListCustomPersons_Person person = new ListCustomPersonsResponse.ListCustomPersons_Category.ListCustomPersons_Person();
					person.PersonName = _ctx.StringValue("ListCustomPersons.Categories["+ i +"].Persons["+ j +"].PersonName");
					person.PersonDescription = _ctx.StringValue("ListCustomPersons.Categories["+ i +"].Persons["+ j +"].PersonDescription");
					person.PersonId = _ctx.StringValue("ListCustomPersons.Categories["+ i +"].Persons["+ j +"].PersonId");

					List<ListCustomPersonsResponse.ListCustomPersons_Category.ListCustomPersons_Person.ListCustomPersons_Face> person_faces = new List<ListCustomPersonsResponse.ListCustomPersons_Category.ListCustomPersons_Person.ListCustomPersons_Face>();
					for (int k = 0; k < _ctx.Length("ListCustomPersons.Categories["+ i +"].Persons["+ j +"].Faces.Length"); k++) {
						ListCustomPersonsResponse.ListCustomPersons_Category.ListCustomPersons_Person.ListCustomPersons_Face face = new ListCustomPersonsResponse.ListCustomPersons_Category.ListCustomPersons_Person.ListCustomPersons_Face();
						face.ImageUrl = _ctx.StringValue("ListCustomPersons.Categories["+ i +"].Persons["+ j +"].Faces["+ k +"].ImageUrl");
						face.FaceId = _ctx.StringValue("ListCustomPersons.Categories["+ i +"].Persons["+ j +"].Faces["+ k +"].FaceId");

						person_faces.Add(face);
					}
					person.Faces = person_faces;

					category_persons.Add(person);
				}
				category.Persons = category_persons;

				listCustomPersonsResponse_categories.Add(category);
			}
			listCustomPersonsResponse.Categories = listCustomPersonsResponse_categories;
        
			return listCustomPersonsResponse;
        }
    }
}
