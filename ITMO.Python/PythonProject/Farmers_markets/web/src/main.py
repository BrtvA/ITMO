from flask import Flask, render_template, request, redirect, url_for
from BAL import request_handler

DATABASE_NAME = "test_market"
DATABASE_USER = "postgres"
DATABASE_PASSWORD = "pgpassword"
DATABASE_HOST = "127.0.0.1"
DATABASE_PORT = "5432"

app = Flask(__name__, template_folder='../templates', static_folder='../static')


@app.route("/", methods=['GET'])
def index():
    handler = request_handler.RequestHandler(DATABASE_NAME, DATABASE_USER,
                                             DATABASE_PASSWORD, DATABASE_HOST,
                                             DATABASE_PORT)
    return render_template("index.html", context=handler.handle_request_sort())


@app.route('/sort', methods=['GET'])
def get_sorted_list():
    handler = request_handler.RequestHandler(DATABASE_NAME, DATABASE_USER,
                                             DATABASE_PASSWORD, DATABASE_HOST,
                                             DATABASE_PORT)
    return render_template("index.html", context=handler.handle_request_sort(request.args.get('page'),
                                                                             request.args.get('sort_param'),
                                                                             request.args.get('sort_type'),
                                                                             request.args.get('x'),
                                                                             request.args.get('y')))


@app.route('/find', methods=['GET'])
def find_list():
    handler = request_handler.RequestHandler(DATABASE_NAME, DATABASE_USER,
                                             DATABASE_PASSWORD, DATABASE_HOST,
                                             DATABASE_PORT)
    return render_template("index.html", context=handler.handle_request_find(request.args.get('city'),
                                                                             request.args.get('state'),
                                                                             request.args.get('zip'),
                                                                             request.args.get('distance'),
                                                                             request.args.get('x'),
                                                                             request.args.get('y')))


@app.route('/review', methods=['POST'])
def add_review():
    handler = request_handler.RequestHandler(DATABASE_NAME, DATABASE_USER,
                                             DATABASE_PASSWORD, DATABASE_HOST,
                                             DATABASE_PORT)
    redirected, error = handler.handle_request_review(request.form['market_id'],
                                                      request.form['rating'],
                                                      request.form['firstname'],
                                                      request.form['lastname'],
                                                      request.form['text'])
    if redirected is None or redirected == "info":
        return redirect(url_for('get_market_info', market_id=request.form['market_id'], error=error))
    else:
        redirect(url_for('index'))


@app.route('/market/<int:market_id>', methods=['GET'])
def get_market_info(market_id: int):
    handler = request_handler.RequestHandler(DATABASE_NAME, DATABASE_USER,
                                             DATABASE_PASSWORD, DATABASE_HOST,
                                             DATABASE_PORT)
    error = request.args.get('error')
    return render_template("info.html", context=handler.handle_request_info(market_id, error))


if __name__ == "__main__":
    app.run(debug=True)
